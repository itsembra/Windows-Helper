namespace WindowsHelper
{
    partial class ZIP_RAR_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZIP_RAR_Window));
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.WinRAR_Label_Text = new System.Windows.Forms.Label();
            this.Farbe_Unter_Dem_Text_WinRAR = new System.Windows.Forms.GroupBox();
            this.WinRAR_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(347, 65);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(125, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 0;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // WinRAR_Label_Text
            // 
            this.WinRAR_Label_Text.AutoSize = true;
            this.WinRAR_Label_Text.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinRAR_Label_Text.Location = new System.Drawing.Point(21, 20);
            this.WinRAR_Label_Text.Name = "WinRAR_Label_Text";
            this.WinRAR_Label_Text.Size = new System.Drawing.Size(125, 42);
            this.WinRAR_Label_Text.TabIndex = 1;
            this.WinRAR_Label_Text.Text = "WinRAR";
            // 
            // Farbe_Unter_Dem_Text_WinRAR
            // 
            this.Farbe_Unter_Dem_Text_WinRAR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Text_WinRAR.Location = new System.Drawing.Point(12, 65);
            this.Farbe_Unter_Dem_Text_WinRAR.Name = "Farbe_Unter_Dem_Text_WinRAR";
            this.Farbe_Unter_Dem_Text_WinRAR.Size = new System.Drawing.Size(142, 10);
            this.Farbe_Unter_Dem_Text_WinRAR.TabIndex = 2;
            this.Farbe_Unter_Dem_Text_WinRAR.TabStop = false;
            // 
            // WinRAR_Link
            // 
            this.WinRAR_Link.AutoSize = true;
            this.WinRAR_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinRAR_Link.Location = new System.Drawing.Point(176, 36);
            this.WinRAR_Link.Name = "WinRAR_Link";
            this.WinRAR_Link.Size = new System.Drawing.Size(159, 12);
            this.WinRAR_Link.TabIndex = 3;
            this.WinRAR_Link.TabStop = true;
            this.WinRAR_Link.Text = "https://bit.ly/3sQWLjx";
            this.WinRAR_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WinRAR_Link_LinkClicked);
            // 
            // ZIP_RAR_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 103);
            this.Controls.Add(this.WinRAR_Link);
            this.Controls.Add(this.Farbe_Unter_Dem_Text_WinRAR);
            this.Controls.Add(this.WinRAR_Label_Text);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 142);
            this.MinimumSize = new System.Drawing.Size(500, 142);
            this.Name = "ZIP_RAR_Window";
            this.Text = "Windows Helper (ZIP/RAR Extracter)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Back_To_Main_Menu_Button;
        private Label WinRAR_Label_Text;
        private GroupBox Farbe_Unter_Dem_Text_WinRAR;
        private LinkLabel WinRAR_Link;
    }
}