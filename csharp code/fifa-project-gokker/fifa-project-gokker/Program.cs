﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifa_project_gokker
{
    static class Program
    {
        public static bool isLoggedIn = false;
        public static List<data> teamList = new List<data>();
        public static List<dataUsers> userslist = new List<dataUsers>();
        public static List<dataWedstrijden> wedstrijdlist = new List<dataWedstrijden>();

        public static GokkerCollection gokkerCollection = new GokkerCollection();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
