using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using turnosDashboard.Models;

namespace turnosDashboard
{
    public partial class dashboard : Form
    {
        private Timer tmHora;
        private Timer tmRefesh;

        System.Threading.Thread weatherDinamicThread;
        System.Threading.Thread weatherDefaultThread;

        public dashboard()
        {
            InitializeComponent();

            this.initializeControls();
        }


        void getWeatherDefaultData()
        {
            strctWeather data = weather.get(turnosDashboard.Properties.Settings.Default.WeatherDefault);
            if (data != null)
            {
                lblDefaultWeather.Invoke((MethodInvoker)(() => lblDefaultWeather.Text = string.Format("{0} {1} °C", data.Name, data.Temp)));
                pbIconDefaultWeather.Invoke((MethodInvoker)(() => pbIconDefaultWeather.Load(data.UrlIcon)));
                System.Threading.Thread.Sleep(decimal.ToInt32(turnosDashboard.Properties.Settings.Default.WeatherDefaultRefresh * 60 * 1000));
            }
            getWeatherDefaultData();
        }


        void getWeatherDinamicData()
        {
            foreach (caWeathers item in weather.getCaWeathers())
            {
                strctWeather data = weather.get(string.Format("{0},mx",item.weather.ToString().Trim()));

                if (data != null)
                {
                    lblOtherWeather.Invoke((MethodInvoker)(() => lblOtherWeather.Text = string.Format("{0} {1} °C", data.Name, data.Temp)));
                    pbIconOtherWeather.Invoke((MethodInvoker)(() => pbIconOtherWeather.Load(data.UrlIcon)));
                    System.Threading.Thread.Sleep(decimal.ToInt32(turnosDashboard.Properties.Settings.Default.WeatherDinamicRefresh * 60 * 1000));
                }
            }
            getWeatherDinamicData();
        }


        void initializeControls() {
            //Inicializar el label de la fecha
            lblFecha.Text = String.Format("{0:dddd, d} de {0:MMMM} de {0:yyyy}", DateTime.Now);


            weatherDefaultThread = new System.Threading.Thread(getWeatherDefaultData);            
            weatherDefaultThread.Start();

            weatherDinamicThread = new System.Threading.Thread(getWeatherDinamicData);
            weatherDinamicThread.Start(); 


            //Configurar timer que muestra la hora
            tmHora = new Timer();
            tmHora.Interval = 1000;
            tmHora.Tick += tmHora_Tick;
            tmHora.Start();

            turnosModel.turnoState();

            //Configurar el timer que actualizará los turnos a patir del API REST Full
            tmRefesh = new Timer();
            tmRefesh.Interval = turnosDashboard.Properties.Settings.Default.RESTCallInterval;
            tmRefesh.Tick += tmRefesh_Tick;
            tmRefesh.Start();

            player.Ctlcontrols.play();
        }

        void tmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Invoke((MethodInvoker)(()=> lblHora.Text = String.Format("{0:T}", DateTime.Now)));

            if (lblHora.Tag.ToString() == "0")
            {
                lblHora.Tag = "1";
                lblHora.Visible = true;
            }
        }

        void tmRefesh_Tick(object sender, EventArgs e)
        {
            turnosModel.turnoState();
        }

        public void refreshControls(){
            lblTurno.Invoke((MethodInvoker)(() => lblTurno.Text = String.Format("{0}", turnosModel.TurnoActual.Turno.ToString())));
            lblVentanilla.Invoke((MethodInvoker)(() => lblVentanilla.Text = String.Format("{0}", turnosModel.TurnoActual.Ventanilla.ToString())));

            short iter = 0;
            if (turnosModel.TurnosAtendiendo.Count() != 0)
            {
                foreach (turno item in (turnosModel.TurnosAtendiendo.Count() == 1 ? turnosModel.TurnosAtendiendo : turnosModel.TurnosAtendiendo.GetRange(turnosModel.TurnosAtendiendo.Count() - 2, 2)))
                {
                    if (iter == 0)
                    {
                        lblTurno1Atiende.Invoke((MethodInvoker)(() => lblTurno1Atiende.Text = String.Format("{0}", item.Turno.ToString())));
                        lblVentanilla1Atiende.Invoke((MethodInvoker)(() => lblVentanilla1Atiende.Text = String.Format("{0}", item.Ventanilla.ToString())));
                        lblServicio1Atiende.Invoke((MethodInvoker)(() => lblServicio1Atiende.Text = String.Format("{0}", item.Tramite.ToString())));
                    }
                    else
                    {
                        lblTurno2Atiende.Invoke((MethodInvoker)(() => lblTurno2Atiende.Text = String.Format("{0}", item.Turno.ToString())));
                        lblVentanilla2Atiende.Invoke((MethodInvoker)(() => lblVentanilla2Atiende.Text = String.Format("{0}", item.Ventanilla.ToString())));
                        lblServicio2Atiende.Invoke((MethodInvoker)(() => lblServicio2Atiende.Text = String.Format("{0}", item.Tramite.ToString())));
                    }
                    iter++;
                }
            }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = string.Format("{0}\\{1}{2}", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Assets\Sounds\", "defaultSound.wav");
            player.Play();
        }

        private void dashboard_Paint(object sender, PaintEventArgs e)
        {
            Size tam = new System.Drawing.Size(lblVentanilla.Width, lblVentanilla.Height);
            lblVentanilla.MaximumSize = tam;
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            weatherDinamicThread.Abort();
            weatherDefaultThread.Abort();
        }
    }
}
