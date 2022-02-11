using System;
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
    public partial class Basic_Windows_Main_Menu_Window : Form
    {
        public Basic_Windows_Main_Menu_Window()
        {
            InitializeComponent();
        }

        private bool Learning = false;
        private bool Start_Learning_Button_Click_Check = false;

        private void Back_To_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main_Menu_Window().Show();
        }

        private void Start_Learning_Button_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Click - Yes - for the next Step!", "Windows Helper (Windows Basics)", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                case DialogResult.Yes:

                    Learning = true;

                    if (Learning)
                    {
                        //speichert den status
                        WinBasics.Default.Show = Chapter1_Button.Visible = true;
                        WinBasics.Default.Show = Chapter1_Button.Enabled = true;

                        WinBasics.Default.Show = Chapter1_Text.Visible = true;
                        WinBasics.Default.Show = Chapter1_Text.Enabled = true;

                        WinBasics.Default.Show = Start_Learning_Button_Click_Check = true;
                        WinBasics.Default.Show = Learning = true;

                        this.Hide();
                        new Basic_Windows_Main_Menu_Window().Show();
                    }
                    break;
                case DialogResult.No:

                    if (!Learning)
                    {
                        WinBasics.Default.Show = Learning = false;
                        WinBasics.Default.Show = Start_Learning_Button_Click_Check = false;

                        this.Hide();
                        new Main_Menu_Window().Show();
                    }
                    break;
            }
        }

        private void Chapter1_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Basic_Windows_Main_Menu_Window_Load(object sender, EventArgs e)
        {
            Learning = WinBasics.Default.Show;
            Start_Learning_Button_Click_Check = WinBasics.Default.Show;

            switch (Learning && Start_Learning_Button_Click_Check)
            {
                case true:
                    Start_Learning_Button.Enabled = false;
                    Start_Learning_Button.Visible = false;
                    break;
                case false:
                    break;
            }

            //lädt den status
            Chapter1_Button.Visible = WinBasics.Default.Show;
            Chapter1_Text.Visible = WinBasics.Default.Show;

            Chapter1_Button.Enabled = WinBasics.Default.Show;
            Chapter1_Text.Enabled = WinBasics.Default.Show;
        }
    }
}
