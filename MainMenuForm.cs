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
        Thread th;
        public Main_Menu_Window()
        {
            InitializeComponent();
        }

        private bool Dark_Mode_Check;
        private bool Light_Mode_Check;
        private bool Rick_Rolle_Check;

        private void opennewform()
        {
            Application.Run(new Main_Menu_Window());
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
            if (MessageBox.Show("Do you really want to open this Link?", "YouTube-Link", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("RickRolle.bat");
            }

        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            if (!Rick_Rolle_Check)
            {
                if (MessageBox.Show("Do you really want to restart this Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            else if (Rick_Rolle_Check)
            {
                if (MessageBox.Show("RickRolled!!!", ";)", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    Process.Start("RickRolle.bat");
                    Application.Restart();
                }
            }
        }

        private void Basic_Windows_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Feature is under Production!", "Basic Windows Infos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Basic_Windows_Button.Enabled = false;
            }

            /*this.Hide();
            new Basic_Windows_Main_Menu_Window().Show();*/
        }

        private void How_to_Update_Button_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This Feature is under Production!", "How To Update", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                How_to_Update_Button.Enabled = false;
            }

            /*this.Hide();
            new How_to_Update_Firmware_Window().Show();*/
        }

        private void Surface_Infos_Button_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This Feature is under Production!", "Surface Infos", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Surface_Infos_Button.Enabled = false;
            }

            /*this.Hide();
            new Surface_Infos_Window().Show();*/
        }

        private void Dark_Mode_Button_Click(object sender, EventArgs e)
        {
            Dark_Mode_Check = true;
            Light_Mode_Check = false;
            
            if (Dark_Mode_Check == true && Light_Mode_Check == false)
            {
                this.BackColor = Color.Black;

                Browser_Text.BackColor = Color.LightGray;
                ZIP_and_RAR_Extracter_Text.BackColor= Color.LightGray;
                Optimization_Videos_For_Windows_Gaming_Text.BackColor = Color.LightGray;
                Optimization_Videos_For_Windows_Office_Text.BackColor = Color.LightGray;
                Tuning_Pack_Text.BackColor = Color.LightGray;
                Ultimative_Performance_Power_Plan_Text.BackColor = Color.LightGray;
                Other_Text.BackColor = Color.LightGray;
                Basic_Windows_Infos_Label.BackColor = Color.LightGray;
                How_To_Update_Label.BackColor= Color.LightGray;
                Surface_Info_Label.BackColor = Color.LightGray;

                Main_Menu_Text.BackColor = Color.LightGray;
                Rick_Role_Label.BackColor = Color.LightGray;
                Info_Text_Title.BackColor = Color.LightGray;
                Info_Text.BackColor = Color.LightGray;
                Dark_Mode_Label_Fun.BackColor = Color.LightGray;
                Gaming_Label.BackColor = Color.LightGray;

                Dark_Mode_Label_Fun.Visible = true;
            }
        }

        private void Light_Mode_Button_Click(object sender, EventArgs e)
        {
            Light_Mode_Check = true;
            Dark_Mode_Check = false;

            if (Light_Mode_Check == true && Dark_Mode_Check == false)
            {
                this.BackColor = Main_Menu_Window.DefaultBackColor;

                Browser_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                ZIP_and_RAR_Extracter_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Optimization_Videos_For_Windows_Gaming_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Optimization_Videos_For_Windows_Office_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Tuning_Pack_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Ultimative_Performance_Power_Plan_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Other_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Basic_Windows_Infos_Label.BackColor = Main_Menu_Window.DefaultBackColor;
                How_To_Update_Label.BackColor = Main_Menu_Window.DefaultBackColor;
                Surface_Info_Label.BackColor = Main_Menu_Window.DefaultBackColor;

                Main_Menu_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Rick_Role_Label.BackColor = Main_Menu_Window.DefaultBackColor;
                Info_Text_Title.BackColor = Main_Menu_Window.DefaultBackColor;
                Info_Text.BackColor = Main_Menu_Window.DefaultBackColor;
                Dark_Mode_Label_Fun.BackColor = Main_Menu_Window.DefaultBackColor;
                Gaming_Label.BackColor = Main_Menu_Window.DefaultBackColor;

                Dark_Mode_Label_Fun.Visible = false;
            }
        }

        private void Dark_Mode_Label_Fun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wow!", "Wow!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK) 
            {
                Quit_Exit_Button.Enabled = false;
                Light_Mode_Button.Enabled = false;
                Dark_Mode_Button.Enabled = false;
                Browser_Button.Enabled = false;
                Tuning_Pack_Button.Enabled = false;
                ZIP_RAR_Button.Enabled = false;
                Optimization_Videos_Gaming_Button.Enabled = false;
                Optimization_Videos_Office_Button.Enabled = false;
                Ulti_Perf_Button.Enabled = false;
                Other_Button.Enabled = false;
                Basic_Windows_Button.Enabled = false;
                How_to_Update_Button.Enabled = false;
                Surface_Infos_Button.Enabled = false;
                Windows_11_Button.Enabled = false;
                Windows_Cleaners_Button.Enabled = false;
                Number_Generator_Button.Enabled = false;
                Gaming_Button.Enabled = false;

                Process.Start("RickRolle.bat");

                Rick_Rolle_Check = true;

            }
            Dark_Mode_Label_Fun.Visible = false;
        }

        private void Main_Menu_Window_Load(object sender, EventArgs e)
        {
            Light_Mode_Check = false;
            Dark_Mode_Check = false;
            Rick_Rolle_Check = false;
            Shutdown_Button.Enabled = true;

            Dark_Mode_Label_Fun.Visible = false;
        }

        private void Windows_11_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Windows_11_Window().Show();
        }

        private void Windows_Cleaners_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Windows_Cleaners_Window().Show();
        }

        private void Number_Generator_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to open this Link?", "GitHub-Link", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("Number.bat");
            }
        }

        private void Shutdown_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Feature is under Production!", "Shutdown Button", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Shutdown_Button.Enabled = false;
            }
        }

        private void Gaming_Button_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This Feature is under Production!", "Gaming", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Gaming_Button.Enabled = false;
            }

            /*this.Hide();
            new Gaming_Window().Show();*/
        }
    }
}
