using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace RESTAmpTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RESTAmpTray form = new RESTAmpTray();
            form.Visible = false;

            Application.Run();
        }
    }
}
