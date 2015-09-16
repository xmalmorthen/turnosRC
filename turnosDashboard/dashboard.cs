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

        public dashboard()
        {
            InitializeComponent();

            this.initializeControls();
        }

        void initializeControls() {
            //Inicializar el label de la fecha
            lblFecha.Text = String.Format("{0:dddd, d} de {0:MMMM} de {0:yyyy}", DateTime.Now);
            
            //Configurar timer que muestra la hora
            tmHora = new Timer();
            tmHora.Interval = 1000;
            tmHora.Tick += tmHora_Tick;
            tmHora.Start();

            //Configurar el timer que actualizará los turnos a patir del API REST Full
            tmRefesh = new Timer();
            tmRefesh.Interval = 2000;
            tmRefesh.Tick += tmRefesh_Tick;
            tmRefesh.Start();
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
            foreach (turno item in turnosModel.TurnosAtendiendo.GetRange(turnosModel.TurnosAtendiendo.Count() - 1, 2))
	        {
                if (iter == 0)
                {
                    lblTurno1Atiende.Invoke((MethodInvoker)(() => lblTurno1Atiende.Text = String.Format("{0}", item.Turno.ToString())));
                    lblVentanilla1Atiende.Invoke((MethodInvoker)(() => lblVentanilla1Atiende.Text = String.Format("{0}", item.Ventanilla.ToString())));
                    lblServicio1Atiende.Invoke((MethodInvoker)(() => lblServicio1Atiende.Text = String.Format("{0}", item.Tramite.ToString())));
                }
                else {
                    lblTurno2Atiende.Invoke((MethodInvoker)(() => lblTurno2Atiende.Text = String.Format("{0}", item.Turno.ToString())));
                    lblVentanilla2Atiende.Invoke((MethodInvoker)(() => lblVentanilla2Atiende.Text = String.Format("{0}", item.Ventanilla.ToString())));
                    lblServicio2Atiende.Invoke((MethodInvoker)(() => lblServicio2Atiende.Text = String.Format("{0}", item.Tramite.ToString())));
                }
                iter++;
	        } 
        }
    }
}
