﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using System.Runtime;
using System.Web;
using System.DirectoryServices;
using System.Formats;
using System.Configuration;
using System.Xaml;
using System.Xml;
using System.IO;
using System.Resources;

namespace WindowsHelper
{
    public partial class ZIP_RAR_Window : Form
    {
        public ZIP_RAR_Window()
        {
            InitializeComponent();
        }

        private void Back_To_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Menu_Window().Show();
        }
    }
}
