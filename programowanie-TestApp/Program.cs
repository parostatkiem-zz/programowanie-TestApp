using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace programowanie_TestApp
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
            Model model = new Model();
            ViewCreator view = new ViewCreator();
            Presenter p = new Presenter(model, view);
            Application.Run(view);
        }
    }
}
