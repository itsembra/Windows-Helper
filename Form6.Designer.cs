namespace WindowsHelper
{
    partial class Optimization_For_Gaming_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optimization_For_Gaming_Window));
            this.YouTube_Text = new System.Windows.Forms.Label();
            this.Farbe_Unter_Dem_Text_YouTube = new System.Windows.Forms.GroupBox();
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Opti_Gaming_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // YouTube_Text
            // 
            this.YouTube_Text.AutoSize = true;
            this.YouTube_Text.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YouTube_Text.Location = new System.Drawing.Point(21, 18);
            this.YouTube_Text.Name = "YouTube_Text";
            this.YouTube_Text.Size = new System.Drawing.Size(136, 42);
            this.YouTube_Text.TabIndex = 0;
            this.YouTube_Text.Text = "YouTube";
            // 
            // Farbe_Unter_Dem_Text_YouTube
            // 
            this.Farbe_Unter_Dem_Text_YouTube.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Text_YouTube.Location = new System.Drawing.Point(12, 63);
            this.Farbe_Unter_Dem_Text_YouTube.Name = "Farbe_Unter_Dem_Text_YouTube";
            this.Farbe_Unter_Dem_Text_YouTube.Size = new System.Drawing.Size(150, 10);
            this.Farbe_Unter_Dem_Text_YouTube.TabIndex = 1;
            this.Farbe_Unter_Dem_Text_YouTube.TabStop = false;
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(363, 89);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(122, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 2;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // Opti_Gaming_Link
            // 
            this.Opti_Gaming_Link.AutoSize = true;
            this.Opti_Gaming_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Opti_Gaming_Link.Location = new System.Drawing.Point(181, 34);
            this.Opti_Gaming_Link.Name = "Opti_Gaming_Link";
            this.Opti_Gaming_Link.Size = new System.Drawing.Size(159, 12);
            this.Opti_Gaming_Link.TabIndex = 3;
            this.Opti_Gaming_Link.TabStop = true;
            this.Opti_Gaming_Link.Text = "https://bit.ly/3pMa2rz";
            this.Opti_Gaming_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Opti_Gaming_Link_LinkClicked);
            // 
            // Optimization_For_Gaming_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 124);
            this.Controls.Add(this.Opti_Gaming_Link);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Controls.Add(this.Farbe_Unter_Dem_Text_YouTube);
            this.Controls.Add(this.YouTube_Text);
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(513, 163);
            this.MinimumSize = new System.Drawing.Size(513, 163);
            this.Name = "Optimization_For_Gaming_Window";
            this.Text = "Windows Helper (Optimization For Gaming)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label YouTube_Text;
        private GroupBox Farbe_Unter_Dem_Text_YouTube;
        private Button Back_To_Main_Menu_Button;
        private LinkLabel Opti_Gaming_Link;
    }
}