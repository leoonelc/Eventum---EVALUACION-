﻿using Eventum.Vistas;
using System;
using System.Windows.Forms;

namespace Eventum
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
            Application.Run(new LoginForm()); // Cambia Form1 por LoginForm
        }
    }
}
