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
    public partial class Login_Window : Form
    {
        public Login_Window()
        {
            InitializeComponent();
        }

        private void Login_Window_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("You need the admin Password and Account to access the Beta! V. 0.2.3 / Please report Bugs on the offical Github Site!", "Short Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {

            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit/quit this Application?", "Exit/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Account_Text_Eingabe.Clear();
                Passwort_Text_Eingabe.Clear();
            }
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit/quit this Application?", "Exit/Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Account_Text_Eingabe.Text == "admin" && Passwort_Text_Eingabe.Text == "admin2007performance")
            {
                if (MessageBox.Show("Succesfully logged you in", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Hide();
                    new Terms_of_Use_Window().Show();
                }
                else
                {
                    switch (MessageBox.Show("Lofin failed, please try again!", "Login failed", MessageBoxButtons.OK))
                    {
                        case DialogResult.OK:
                            Account_Text_Eingabe.Clear();
                            Passwort_Text_Eingabe.Clear();
                            break;
                    }
                }
            }
        }
    }
}