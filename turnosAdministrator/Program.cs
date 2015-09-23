using NLog;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turnosAdministrator
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Init();
        }

        static void Init() {            
            frmLogIn LogIn = new frmLogIn();
            if (LogIn.ShowDialog() == DialogResult.OK)
            {
                LogIn.Close();
                LogIn.Dispose();
                LogIn = null;

                frmMain MainFrm = new frmMain();
                if (MainFrm.ShowDialog() == DialogResult.Retry)
                {
                    MainFrm.Close();
                    MainFrm.Dispose();
                    MainFrm = null;
                    Init();
                }
                Application.Exit();                
            }
        }

    }
}
