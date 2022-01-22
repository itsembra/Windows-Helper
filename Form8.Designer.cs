namespace WindowsHelper
{
    partial class Tuning_Pack_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tuning_Pack_Window));
            this.Tuning_Pack_Text = new System.Windows.Forms.Label();
            this.Farbe_Unter_Dem_Text_Tuning_Pack = new System.Windows.Forms.GroupBox();
            this.Tuning_Pack_Link = new System.Windows.Forms.LinkLabel();
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.YouTube_Info_Link = new System.Windows.Forms.LinkLabel();
            this.YouTube_Text_Info_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tuning_Pack_Text
            // 
            this.Tuning_Pack_Text.AutoSize = true;
            this.Tuning_Pack_Text.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tuning_Pack_Text.Location = new System.Drawing.Point(23, 19);
            this.Tuning_Pack_Text.Name = "Tuning_Pack_Text";
            this.Tuning_Pack_Text.Size = new System.Drawing.Size(188, 42);
            this.Tuning_Pack_Text.TabIndex = 0;
            this.Tuning_Pack_Text.Text = "Tuning Pack";
            // 
            // Farbe_Unter_Dem_Text_Tuning_Pack
            // 
            this.Farbe_Unter_Dem_Text_Tuning_Pack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Text_Tuning_Pack.Location = new System.Drawing.Point(12, 64);
            this.Farbe_Unter_Dem_Text_Tuning_Pack.Name = "Farbe_Unter_Dem_Text_Tuning_Pack";
            this.Farbe_Unter_Dem_Text_Tuning_Pack.Size = new System.Drawing.Size(211, 10);
            this.Farbe_Unter_Dem_Text_Tuning_Pack.TabIndex = 1;
            this.Farbe_Unter_Dem_Text_Tuning_Pack.TabStop = false;
            // 
            // Tuning_Pack_Link
            // 
            this.Tuning_Pack_Link.AutoSize = true;
            this.Tuning_Pack_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tuning_Pack_Link.Location = new System.Drawing.Point(233, 35);
            this.Tuning_Pack_Link.Name = "Tuning_Pack_Link";
            this.Tuning_Pack_Link.Size = new System.Drawing.Size(159, 12);
            this.Tuning_Pack_Link.TabIndex = 2;
            this.Tuning_Pack_Link.TabStop = true;
            this.Tuning_Pack_Link.Text = "https://bit.ly/3nb57z1";
            this.Tuning_Pack_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Tuning_Pack_Link_LinkClicked);
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(555, 113);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(119, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 3;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // YouTube_Info_Link
            // 
            this.YouTube_Info_Link.AutoSize = true;
            this.YouTube_Info_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YouTube_Info_Link.Location = new System.Drawing.Point(464, 44);
            this.YouTube_Info_Link.Name = "YouTube_Info_Link";
            this.YouTube_Info_Link.Size = new System.Drawing.Size(159, 12);
            this.YouTube_Info_Link.TabIndex = 4;
            this.YouTube_Info_Link.TabStop = true;
            this.YouTube_Info_Link.Text = "https://bit.ly/3JAfrKk";
            this.YouTube_Info_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YouTube_Info_Link_LinkClicked);
            // 
            // YouTube_Text_Info_Label
            // 
            this.YouTube_Text_Info_Label.AutoSize = true;
            this.YouTube_Text_Info_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YouTube_Text_Info_Label.Location = new System.Drawing.Point(430, 19);
            this.YouTube_Text_Info_Label.Name = "YouTube_Text_Info_Label";
            this.YouTube_Text_Info_Label.Size = new System.Drawing.Size(107, 15);
            this.YouTube_Text_Info_Label.TabIndex = 5;
            this.YouTube_Text_Info_Label.Text = "YouTube Tutorial:";
            // 
            // Tuning_Pack_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 148);
            this.Controls.Add(this.YouTube_Text_Info_Label);
            this.Controls.Add(this.YouTube_Info_Link);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Controls.Add(this.Tuning_Pack_Link);
            this.Controls.Add(this.Farbe_Unter_Dem_Text_Tuning_Pack);
            this.Controls.Add(this.Tuning_Pack_Text);
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 187);
            this.MinimumSize = new System.Drawing.Size(702, 187);
            this.Name = "Tuning_Pack_Window";
            this.Text = "Windows Helper (Tuning Pack)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tuning_Pack_Text;
        private GroupBox Farbe_Unter_Dem_Text_Tuning_Pack;
        private LinkLabel Tuning_Pack_Link;
        private Button Back_To_Main_Menu_Button;
        private LinkLabel YouTube_Info_Link;
        private Label YouTube_Text_Info_Label;
    }
}