using MetroFramework;
using MetroFramework.Forms;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using turnosAdministrator.Models;
using turnosAdministrator.Models.structures;
using System.Threading;

namespace turnosAdministrator
{
    public partial class frmMain : MetroForm
    {
        private DBDataContext db = new DBDataContext();

        private caWeathers dataToEdit = new caWeathers();
        private int position = 0;

        public enum frmStates
        {
            displayWeather,
            newWeather,
            saveNewWeather,
            editWeather,
            deleteWeather
        }
        private frmStates frmState;
        public frmStates FrmState
        {
            get { return frmState; }
            set 
            {
                try
                {
                
                    txtWeather.Enabled = value == frmStates.editWeather || value == frmStates.newWeather;
                    txtWeatherDescrip.Enabled = value == frmStates.editWeather || value == frmStates.newWeather;
                    pnlBtns.Enabled = value == frmStates.editWeather || value == frmStates.newWeather;

                    pbNew.Visible = value == frmStates.displayWeather;
                    tableLayoutPanel3.Enabled = value == frmStates.displayWeather;

                    splitContainer1.Panel2Collapsed = value == frmStates.editWeather || value == frmStates.newWeather;
                
                    switch (value)
                    {
                        case frmStates.displayWeather:
                            refreshData();
                            caWeathersBindingSource.ResumeBinding();
                            break;
                        case frmStates.newWeather:
                            btnAcceptWeatherForm.Tag = "newWeather";
                            caWeathersBindingSource.SuspendBinding();
                            txtWeather.Focus();
                            break;
                        case frmStates.saveNewWeather:
                            if (btnAcceptWeatherForm.Tag.ToString() == "newWeather")
                            {
                                caWeathers itemToAdd = new caWeathers();
                                itemToAdd.weather = txtWeather.Text.Trim();
                                itemToAdd.description = txtWeatherDescrip.Text.Trim();
                                db.caWeathers.InsertOnSubmit(itemToAdd);
                            }
                            else
                            {
                                caWeathers itemToEdit = db.caWeathers.SingleOrDefault(qry => qry.id == dataToEdit.id);
                                itemToEdit.weather = txtWeather.Text.Trim();
                                itemToEdit.description = txtWeatherDescrip.Text.Trim();
                                itemToEdit.fact = DateTime.Now;
                            }

                            db.SubmitChanges();
                            refreshData();
                            caWeathersBindingSource.ResumeBinding();
                            if (btnAcceptWeatherForm.Tag.ToString() == "newWeather") caWeathersBindingSource.MoveLast(); else caWeathersBindingSource.Position = position;
                            break;
                        case frmStates.editWeather:
                            btnAcceptWeatherForm.Tag = "editWeather";

                            dataToEdit = (caWeathers)caWeathersBindingSource.Current;
                            position = caWeathersBindingSource.Position;
                            caWeathersBindingSource.SuspendBinding();

                            txtWeather.Text = dataToEdit.weather.ToString().Trim();
                            txtWeatherDescrip.Text = dataToEdit.description.ToString().Trim();

                            txtWeather.Focus();
                            txtWeather.SelectAll();
                            break;
                        case frmStates.deleteWeather:
                            db.caWeathers.DeleteOnSubmit(caWeathersBindingSource.Current as caWeathers);
                            db.SubmitChanges();
                            refreshData();                        
                            break;
                    }   
                
                    frmState = value;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void refreshData() {            
            caWeathersBindingSource.DataSource = db.caWeathers.ToList();
        }

        public frmMain()
        {
            InitializeComponent();
            frmState = frmStates.displayWeather;
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroContextMenu.Show(pictureBox2, new Point(0, pictureBox2.Height));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
        }

        private void pbNew_Click(object sender, EventArgs e)
        {            
            FrmState = frmStates.newWeather;
        }

        private void btnAcceptWeatherForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtWeather.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "Debe especificar un Municipio o Ciudad.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWeather.Focus();
                }
                else {
                    if (FrmState == frmStates.newWeather && db.caWeathers.SingleOrDefault(qry => qry.weather.Trim().ToLower() == txtWeather.Text.Trim().ToLower()) != null)
                    {
                        MetroMessageBox.Show(this, "Ya se encuentra un registro con el Municipio o Ciudad.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmState = frmStates.saveNewWeather;
                        MetroMessageBox.Show(this, "Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmState = frmStates.displayWeather;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                MetroMessageBox.Show(this, "Error al intentar guardar, favor de intentarlo de nuevo.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }           
        }

        private void btnCancelWeatherForm_Click(object sender, EventArgs e)
        {
            FrmState = frmStates.displayWeather;
            caWeathersBindingSource.Position = position;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            strctVentanillaBindingSource.DataSource = mainModel.ventanillas();
            Thread actTurnos = new Thread(actualizarTurnos);
            actTurnos.Start();
            
            FrmState = frmStates.displayWeather;
        }

        private void pbDeleteWeatherForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroMessageBox.Show(this, "Confirma el borrado del registro", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    FrmState = frmStates.deleteWeather;
                    MetroMessageBox.Show(this, "Registro borrado.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmState = frmStates.displayWeather;
                }
            }
            catch (Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, ex.Message);
                MetroMessageBox.Show(this, "Error al intentar borrar el registro, favor de intentarlo de nuevo.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        
        private void pbRefreshWeatherForm_Click(object sender, EventArgs e)
        {
            refreshData();
            MetroMessageBox.Show(this,"Registros actualizados", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void pbEditWeatherForm_Click(object sender, EventArgs e)
        {
            FrmState = frmStates.editWeather;
        }

        private void pbActualizarTurnos_Click(object sender, EventArgs e)
        {
            Thread actTurnos = new Thread(actualizarTurnos);
            actTurnos.Start();
        }

        private void actualizarTurnos()
        {
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = false));
            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = true));
            try
            {
                short iter = 0;
                foreach (strctTurno item in mainModel.turnos())
                {
                    switch (iter)
                    {
                        case 0:
                            lblVentanillaActual.Invoke((MethodInvoker)(() => lblVentanillaActual.Text = item.NombreVentanilla));
                            lblTurnoActual.Invoke((MethodInvoker)(() => lblTurnoActual.Text = item.Turno.ToString()));
                            break;
                        case 1:
                            lblVentanilla1Atiende.Invoke((MethodInvoker)(() => lblVentanilla1Atiende.Text = item.NombreVentanilla));
                            lblTurno1Atiende.Invoke((MethodInvoker)(() => lblTurno1Atiende.Text = item.Turno.ToString()));
                            lblServicio1Atiende.Invoke((MethodInvoker)(() => lblServicio1Atiende.Text = item.Tramite));
                            break;
                        case 2:
                            lblVentanilla2Atiende.Invoke((MethodInvoker)(() => lblVentanilla2Atiende.Text = item.NombreVentanilla));
                            lblTurno2Atiende.Invoke((MethodInvoker)(() => lblTurno2Atiende.Text = item.Turno.ToString()));
                            lblServicio2Atiende.Invoke((MethodInvoker)(() => lblServicio2Atiende.Text = item.Tramite));
                            break;
                    }
                    iter++;
                }
            }
            catch (Exception)
            {
            }
            pnlNotifications.Invoke((MethodInvoker)(() => pnlNotifications.Visible = false));
            metroPanel1.Invoke((MethodInvoker)(() => metroPanel1.Enabled = true));
        }

    }
}
