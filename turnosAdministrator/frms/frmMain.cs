using MetroFramework.Forms;
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

namespace turnosAdministrator
{
    public partial class frmMain : MetroForm
    {
        DBDataContext db = new DBDataContext();

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
            set {
                btnAcceptWeatherForm.Enabled = btnCancelWeatherForm.Enabled = false;

                switch (value)
                {
                    case frmStates.displayWeather:
                        caWeathersBindingSource.DataSource = db.caWeathers.ToList();
                        caWeathersBindingSource.ResumeBinding();
                        gdWeathers.Enabled = true;
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
                        db.SubmitChanges();
                        caWeathersBindingSource.DataSource = db.caWeathers.ToList();
                        caWeathersBindingSource.MoveLast();
                        caWeathersBindingSource.ResumeBinding();
                        gdWeathers.Enabled = true;
                        break;
                    case frmStates.editWeather:
                        btnAcceptWeatherForm.Tag = "editWeather";
                        break;
                    case frmStates.deleteWeather:
                        db.caWeathers.DeleteOnSubmit(caWeathersBindingSource.Current as caWeathers);
                        caWeathersBindingSource.SuspendBinding();
                        db.SubmitChanges();
                        caWeathersBindingSource.DataSource = db.caWeathers.ToList();
                        caWeathersBindingSource.ResumeBinding();
                        break;
                }   
                
                frmState = value; }
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
            FrmState = frmStates.saveNewWeather;
        }

        private void btnCancelWeatherForm_Click(object sender, EventArgs e)
        {
            FrmState = frmStates.displayWeather;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FrmState = frmStates.displayWeather;

        }

        private void gdWeathers_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            FrmState = frmStates.editWeather;
        }        

        private void pbDeleteWeatherForm_Click(object sender, EventArgs e)
        {
            FrmState = frmStates.deleteWeather;
        }

        private void gdWeathers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FrmState = frmStates.editWeather;
        }
        
        private void txtWeatherDescrip_Enter(object sender, EventArgs e)
        {
            gdWeathers.Enabled = false;
            btnAcceptWeatherForm.Enabled = true;
            btnCancelWeatherForm.Enabled = true;
        }

    }
}
