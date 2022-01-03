namespace WindowsHelper
{
    partial class Other_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Other_Window));
            this.Gimp_Link = new System.Windows.Forms.LinkLabel();
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Farbe_Unter_Dem_Text_YouTube = new System.Windows.Forms.GroupBox();
            this.Gimp_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gimp_Link
            // 
            this.Gimp_Link.AutoSize = true;
            this.Gimp_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gimp_Link.Location = new System.Drawing.Point(138, 36);
            this.Gimp_Link.Name = "Gimp_Link";
            this.Gimp_Link.Size = new System.Drawing.Size(159, 12);
            this.Gimp_Link.TabIndex = 11;
            this.Gimp_Link.TabStop = true;
            this.Gimp_Link.Text = "https://bit.ly/3HpUVtU";
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(246, 93);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(122, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 10;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // Farbe_Unter_Dem_Text_YouTube
            // 
            this.Farbe_Unter_Dem_Text_YouTube.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Text_YouTube.Location = new System.Drawing.Point(18, 65);
            this.Farbe_Unter_Dem_Text_YouTube.Name = "Farbe_Unter_Dem_Text_YouTube";
            this.Farbe_Unter_Dem_Text_YouTube.Size = new System.Drawing.Size(98, 10);
            this.Farbe_Unter_Dem_Text_YouTube.TabIndex = 9;
            this.Farbe_Unter_Dem_Text_YouTube.TabStop = false;
            // 
            // Gimp_Text
            // 
            this.Gimp_Text.AutoSize = true;
            this.Gimp_Text.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gimp_Text.Location = new System.Drawing.Point(24, 20);
            this.Gimp_Text.Name = "Gimp_Text";
            this.Gimp_Text.Size = new System.Drawing.Size(90, 42);
            this.Gimp_Text.TabIndex = 8;
            this.Gimp_Text.Text = "Gimp";
            // 
            // Other_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 128);
            this.Controls.Add(this.Gimp_Link);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Controls.Add(this.Farbe_Unter_Dem_Text_YouTube);
            this.Controls.Add(this.Gimp_Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 167);
            this.MinimumSize = new System.Drawing.Size(396, 167);
            this.Name = "Other_Window";
            this.Text = "Windows Helper (Other)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Gimp_Link;
        private Button Back_To_Main_Menu_Button;
        private GroupBox Farbe_Unter_Dem_Text_YouTube;
        private Label Gimp_Text;
    }
}