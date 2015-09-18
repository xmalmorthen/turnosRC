using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using turnosAdministrator.Models;

namespace turnosAdministrator
{
    public partial class frmLogIn : MetroForm
    {
        public frmLogIn()
        {
            InitializeComponent();
            metroStyleManager.Style = MetroColorStyle.Silver;
        }

        protected override void OnPaint(PaintEventArgs e) {
            this.FocusMe();
            base.OnPaint(e);
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pbSpnr.Visible = true;            
            session.isValid(txtUsr.Text.Trim(), txtPass.Text.Trim(),);
        }

        public void callBackIsValidFunc(Boolean isValid, string message) { 
            pbSpnr.Visible = false;
            this.Enabled = true;
            if (!isValid)
            {
                MetroMessageBox.Show(this, message, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
    }
}
