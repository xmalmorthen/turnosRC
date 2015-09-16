using System;
using System.Collections.Generic;
using System.Linq;
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

            main = new dashboard();
            main.TopMost = true;
            #if DEBUG
                main.TopMost = false;
            #endif
            Application.Run(main);
        }
    }
}
