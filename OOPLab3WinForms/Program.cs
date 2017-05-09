using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SharpGL;

namespace OOPLab3WinForms
{
    static class Program
    {
        public static OpenGL GL;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
