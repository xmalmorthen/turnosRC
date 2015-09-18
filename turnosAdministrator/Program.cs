using MetroFramework.Demo;
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

            frmLogIn LogIn = new frmLogIn();

            if (LogIn.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
