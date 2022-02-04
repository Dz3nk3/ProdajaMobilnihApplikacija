using ProdajaMobilnihAplikacija.WinUI.Login;
using ProdajaMobilnihAplikacija.WinUI.Pocetna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPocetna());
            //Application.Run(new frmPocetnaAdmin());
            //Application.Run(new AdminEmployee());
            Application.Run(new frmLogin());

        }
    }
}
