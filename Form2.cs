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
    public partial class Terms_of_Use_Window : Form
    {
        public Terms_of_Use_Window()
        {
            InitializeComponent();
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Succesfully accepted the Terms of Use!", "Terms of Use", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MessageBox.Show("If you want to open any Link, tip the Link in the upper Search Bar of your Browser, i made the Links shorter for you! - Sorry :( I am trying to fix this.", "Important Info", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Hide();
                    new Main_Menu_Window().Show();
                }
            }
        }
    }
}
