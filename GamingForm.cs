﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHelper
{
    public partial class Gaming_Window : Form
    {
        public Gaming_Window()
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
