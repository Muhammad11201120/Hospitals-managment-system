﻿using System;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new frmMain() );
            //Application.Run(new frmAllEmployeesList());
        }
    }
}
