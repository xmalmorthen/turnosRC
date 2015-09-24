using NLog;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(assemblyFolder + "\\" + turnosAdministrator.Properties.Settings.Default.ApplicationName + "NLog.config", true);

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
