using System;
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
    public partial class Main_Menu_Window : Form
    {
        public Main_Menu_Window()
        {
            InitializeComponent();
        }

        private void Browser_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Browser_Window().Show();
        }

        private void ZIP_RAR_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ZIP_RAR_Window().Show(); 
        }

        private void Optimization_Videos_Gaming_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Optimization_For_Gaming_Window().Show();
        }

        private void Optimization_Videos_Office_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Optimize_For_Office_Window().Show();
        }

        private void Quit_Exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit/quit this Application?", "Exit/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Tuning_Pack_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tuning_Pack_Window().Show();
        }

        private void Ulti_Perf_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ultimative_Powerplan_Window().Show();
        }

        private void Other_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Other_Window().Show();
        }

        private void Rick_Role_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("RickRolle.bat");
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to restart this Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
