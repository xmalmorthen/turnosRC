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

namespace turnosAdministrator.frms
{
    public partial class frmVideoPlayer : MetroForm
    {
        public frmVideoPlayer()
        {
            InitializeComponent();
        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1) {
                this.Close();
            }
        }
    }
}
