using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turnosDashboard
{
    public partial class dashboard : Form
    {
        private Timer tmHora;

        public dashboard()
        {
            InitializeComponent();

            this.initializeControls();

            tmHora = new Timer();
            tmHora.Interval = 1000;
            tmHora.Tick += tmHora_Tick;
            tmHora.Start();
        }

        void initializeControls() {
            lblFecha.Text = String.Format("{0:dddd, d} de {0:MMMM} de {0:yyyy}", DateTime.Now); 
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



    }
}
