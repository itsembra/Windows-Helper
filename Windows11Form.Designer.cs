namespace WindowsHelper
{
    partial class Windows_11_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows_11_Window));
            this.Windows_11_Link = new System.Windows.Forms.LinkLabel();
            this.Farbe_Unter_Dem_Razer_Cortex_Text = new System.Windows.Forms.GroupBox();
            this.Windows_11_Label = new System.Windows.Forms.Label();
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Windows_11_Link
            // 
            this.Windows_11_Link.AutoSize = true;
            this.Windows_11_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Windows_11_Link.Location = new System.Drawing.Point(232, 40);
            this.Windows_11_Link.Name = "Windows_11_Link";
            this.Windows_11_Link.Size = new System.Drawing.Size(159, 12);
            this.Windows_11_Link.TabIndex = 20;
            this.Windows_11_Link.TabStop = true;
            this.Windows_11_Link.Text = "https://bit.ly/3HdbPfz";
            this.Windows_11_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Windows_11_Link_LinkClicked);
            // 
            // Farbe_Unter_Dem_Razer_Cortex_Text
            // 
            this.Farbe_Unter_Dem_Razer_Cortex_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Location = new System.Drawing.Point(21, 69);
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Name = "Farbe_Unter_Dem_Razer_Cortex_Text";
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Size = new System.Drawing.Size(187, 10);
            this.Farbe_Unter_Dem_Razer_Cortex_Text.TabIndex = 19;
            this.Farbe_Unter_Dem_Razer_Cortex_Text.TabStop = false;
            // 
            // Windows_11_Label
            // 
            this.Windows_11_Label.AutoSize = true;
            this.Windows_11_Label.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Windows_11_Label.Location = new System.Drawing.Point(27, 24);
            this.Windows_11_Label.Name = "Windows_11_Label";
            this.Windows_11_Label.Size = new System.Drawing.Size(177, 42);
            this.Windows_11_Label.TabIndex = 18;
            this.Windows_11_Label.Text = "Windows 11";
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(413, 70);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(122, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 21;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // Windows_11_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 105);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Controls.Add(this.Windows_11_Link);
            this.Controls.Add(this.Farbe_Unter_Dem_Razer_Cortex_Text);
            this.Controls.Add(this.Windows_11_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 144);
            this.MinimumSize = new System.Drawing.Size(563, 144);
            this.Name = "Windows_11_Window";
            this.Text = "Windows Helper (Windows 11)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Windows_11_Link;
        private GroupBox Farbe_Unter_Dem_Razer_Cortex_Text;
        private Label Windows_11_Label;
        private Button Back_To_Main_Menu_Button;
    }
}