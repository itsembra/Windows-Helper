namespace WindowsHelper
{
    partial class Low_End_PC_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Low_End_PC_Window));
            this.Farbe_Unter_Dem_Razer_Cortex_Text = new System.Windows.Forms.GroupBox();
            this.Razer_Cortex_Label = new System.Windows.Forms.Label();
            this.Back_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Razer_Cortex_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Farbe_Unter_Dem_Razer_Cortex_Text
            // 
            this.Farbe_Unter_Dem_Razer_Cortex_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Location = new System.Drawing.Point(19, 67);
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Name = "Farbe_Unter_Dem_Razer_Cortex_Text";
            this.Farbe_Unter_Dem_Razer_Cortex_Text.Size = new System.Drawing.Size(199, 10);
            this.Farbe_Unter_Dem_Razer_Cortex_Text.TabIndex = 15;
            this.Farbe_Unter_Dem_Razer_Cortex_Text.TabStop = false;
            // 
            // Razer_Cortex_Label
            // 
            this.Razer_Cortex_Label.AutoSize = true;
            this.Razer_Cortex_Label.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Razer_Cortex_Label.Location = new System.Drawing.Point(25, 22);
            this.Razer_Cortex_Label.Name = "Razer_Cortex_Label";
            this.Razer_Cortex_Label.Size = new System.Drawing.Size(190, 42);
            this.Razer_Cortex_Label.TabIndex = 14;
            this.Razer_Cortex_Label.Text = "Razer Cortex";
            // 
            // Back_To_Main_Menu_Button
            // 
            this.Back_To_Main_Menu_Button.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back_To_Main_Menu_Button.Location = new System.Drawing.Point(370, 80);
            this.Back_To_Main_Menu_Button.Name = "Back_To_Main_Menu_Button";
            this.Back_To_Main_Menu_Button.Size = new System.Drawing.Size(122, 23);
            this.Back_To_Main_Menu_Button.TabIndex = 16;
            this.Back_To_Main_Menu_Button.Text = "Back to Main Menu";
            this.Back_To_Main_Menu_Button.UseVisualStyleBackColor = true;
            this.Back_To_Main_Menu_Button.Click += new System.EventHandler(this.Back_To_Main_Menu_Button_Click);
            // 
            // Razer_Cortex_Link
            // 
            this.Razer_Cortex_Link.AutoSize = true;
            this.Razer_Cortex_Link.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Razer_Cortex_Link.Location = new System.Drawing.Point(235, 38);
            this.Razer_Cortex_Link.Name = "Razer_Cortex_Link";
            this.Razer_Cortex_Link.Size = new System.Drawing.Size(159, 12);
            this.Razer_Cortex_Link.TabIndex = 17;
            this.Razer_Cortex_Link.TabStop = true;
            this.Razer_Cortex_Link.Text = "https://bit.ly/3GThnvz";
            this.Razer_Cortex_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Razer_Cortex_Link_LinkClicked);
            // 
            // Low_End_PC_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 115);
            this.Controls.Add(this.Razer_Cortex_Link);
            this.Controls.Add(this.Back_To_Main_Menu_Button);
            this.Controls.Add(this.Farbe_Unter_Dem_Razer_Cortex_Text);
            this.Controls.Add(this.Razer_Cortex_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 154);
            this.MinimumSize = new System.Drawing.Size(520, 154);
            this.Name = "Low_End_PC_Window";
            this.Text = "Windows Helper (Low End PC)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Farbe_Unter_Dem_Razer_Cortex_Text;
        private Label Razer_Cortex_Label;
        private Button Back_To_Main_Menu_Button;
        private LinkLabel Razer_Cortex_Link;
    }
}