using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turnosDashboard
{
    static class Program
    {
        public static dashboard main;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(assemblyFolder + "\\" + turnosDashboard.Properties.Settings.Default.ApplicationName + "NLog.config", true);

            main = new dashboard();
            main.TopMost = true;
            main.Location = Screen.AllScreens[turnosDashboard.Properties.Settings.Default.ScreenShowNumber].WorkingArea.Location;

            #if DEBUG
                main.TopMost = false;
            #endif
            Application.Run(main);
        }
    }
}
