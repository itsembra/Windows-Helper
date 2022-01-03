namespace WindowsHelper
{
    partial class Login_Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Text = new System.Windows.Forms.Label();
            this.Farbe_Unter_Dem_Login_Text = new System.Windows.Forms.GroupBox();
            this.Account_Text_Eingabe = new System.Windows.Forms.TextBox();
            this.Passwort_Text_Eingabe = new System.Windows.Forms.TextBox();
            this.Farbe_Unter_Der_Passwort_Eingabe = new System.Windows.Forms.GroupBox();
            this.Farbe_Über_Der_Account_Text_Eingabe = new System.Windows.Forms.GroupBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.Account_Text = new System.Windows.Forms.Label();
            this.Passwort_Text = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Farbe_Oben_Im_Fenster = new System.Windows.Forms.GroupBox();
            this.Farbe_Unten_Im_Fenster = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Login_Text
            // 
            this.Login_Text.AutoSize = true;
            this.Login_Text.Font = new System.Drawing.Font("Impact", 54.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Text.Location = new System.Drawing.Point(26, 29);
            this.Login_Text.Name = "Login_Text";
            this.Login_Text.Size = new System.Drawing.Size(200, 91);
            this.Login_Text.TabIndex = 0;
            this.Login_Text.Text = "Login";
            // 
            // Farbe_Unter_Dem_Login_Text
            // 
            this.Farbe_Unter_Dem_Login_Text.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Farbe_Unter_Dem_Login_Text.Location = new System.Drawing.Point(26, 123);
            this.Farbe_Unter_Dem_Login_Text.Name = "Farbe_Unter_Dem_Login_Text";
            this.Farbe_Unter_Dem_Login_Text.Size = new System.Drawing.Size(200, 10);
            this.Farbe_Unter_Dem_Login_Text.TabIndex = 1;
            this.Farbe_Unter_Dem_Login_Text.TabStop = false;
            // 
            // Account_Text_Eingabe
            // 
            this.Account_Text_Eingabe.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Account_Text_Eingabe.Location = new System.Drawing.Point(255, 201);
            this.Account_Text_Eingabe.Name = "Account_Text_Eingabe";
            this.Account_Text_Eingabe.Size = new System.Drawing.Size(500, 24);
            this.Account_Text_Eingabe.TabIndex = 2;
            // 
            // Passwort_Text_Eingabe
            // 
            this.Passwort_Text_Eingabe.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwort_Text_Eingabe.Location = new System.Drawing.Point(255, 279);
            this.Passwort_Text_Eingabe.Name = "Passwort_Text_Eingabe";
            this.Passwort_Text_Eingabe.Size = new System.Drawing.Size(500, 24);
            this.Passwort_Text_Eingabe.TabIndex = 3;
            // 
            // Farbe_Unter_Der_Passwort_Eingabe
            // 
            this.Farbe_Unter_Der_Passwort_Eingabe.BackColor = System.Drawing.SystemColors.Highlight;
            this.Farbe_Unter_Der_Passwort_Eingabe.Location = new System.Drawing.Point(255, 318);
            this.Farbe_Unter_Der_Passwort_Eingabe.Name = "Farbe_Unter_Der_Passwort_Eingabe";
            this.Farbe_Unter_Der_Passwort_Eingabe.Size = new System.Drawing.Size(500, 10);
            this.Farbe_Unter_Der_Passwort_Eingabe.TabIndex = 4;
            this.Farbe_Unter_Der_Passwort_Eingabe.TabStop = false;
            // 
            // Farbe_Über_Der_Account_Text_Eingabe
            // 
            this.Farbe_Über_Der_Account_Text_Eingabe.BackColor = System.Drawing.SystemColors.Highlight;
            this.Farbe_Über_Der_Account_Text_Eingabe.Location = new System.Drawing.Point(255, 175);
            this.Farbe_Über_Der_Account_Text_Eingabe.Name = "Farbe_Über_Der_Account_Text_Eingabe";
            this.Farbe_Über_Der_Account_Text_Eingabe.Size = new System.Drawing.Size(500, 10);
            this.Farbe_Über_Der_Account_Text_Eingabe.TabIndex = 5;
            this.Farbe_Über_Der_Account_Text_Eingabe.TabStop = false;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(713, 415);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.Text = "Exit/Quit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(713, 386);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 7;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Restart_Button
            // 
            this.Restart_Button.Location = new System.Drawing.Point(12, 415);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(695, 23);
            this.Restart_Button.TabIndex = 8;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = true;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Button_Click);
            // 
            // Account_Text
            // 
            this.Account_Text.AutoSize = true;
            this.Account_Text.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Account_Text.Location = new System.Drawing.Point(60, 187);
            this.Account_Text.Name = "Account_Text";
            this.Account_Text.Size = new System.Drawing.Size(133, 38);
            this.Account_Text.TabIndex = 9;
            this.Account_Text.Text = "Account:";
            // 
            // Passwort_Text
            // 
            this.Passwort_Text.AutoSize = true;
            this.Passwort_Text.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwort_Text.Location = new System.Drawing.Point(60, 265);
            this.Passwort_Text.Name = "Passwort_Text";
            this.Passwort_Text.Size = new System.Drawing.Size(147, 38);
            this.Passwort_Text.TabIndex = 10;
            this.Passwort_Text.Text = "Password:";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(432, 97);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(323, 23);
            this.Login_Button.TabIndex = 11;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Farbe_Oben_Im_Fenster
            // 
            this.Farbe_Oben_Im_Fenster.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Farbe_Oben_Im_Fenster.Location = new System.Drawing.Point(12, 12);
            this.Farbe_Oben_Im_Fenster.Name = "Farbe_Oben_Im_Fenster";
            this.Farbe_Oben_Im_Fenster.Size = new System.Drawing.Size(775, 10);
            this.Farbe_Oben_Im_Fenster.TabIndex = 12;
            this.Farbe_Oben_Im_Fenster.TabStop = false;
            // 
            // Farbe_Unten_Im_Fenster
            // 
            this.Farbe_Unten_Im_Fenster.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Farbe_Unten_Im_Fenster.Location = new System.Drawing.Point(12, 386);
            this.Farbe_Unten_Im_Fenster.Name = "Farbe_Unten_Im_Fenster";
            this.Farbe_Unten_Im_Fenster.Size = new System.Drawing.Size(689, 10);
            this.Farbe_Unten_Im_Fenster.TabIndex = 13;
            this.Farbe_Unten_Im_Fenster.TabStop = false;
            // 
            // Login_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Farbe_Unten_Im_Fenster);
            this.Controls.Add(this.Farbe_Oben_Im_Fenster);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Passwort_Text);
            this.Controls.Add(this.Account_Text);
            this.Controls.Add(this.Restart_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Farbe_Über_Der_Account_Text_Eingabe);
            this.Controls.Add(this.Farbe_Unter_Der_Passwort_Eingabe);
            this.Controls.Add(this.Passwort_Text_Eingabe);
            this.Controls.Add(this.Account_Text_Eingabe);
            this.Controls.Add(this.Farbe_Unter_Dem_Login_Text);
            this.Controls.Add(this.Login_Text);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Login_Window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Windows Helper (Beta-Login)";
            this.Load += new System.EventHandler(this.Login_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Login_Text;
        private GroupBox Farbe_Unter_Dem_Login_Text;
        private TextBox Account_Text_Eingabe;
        private TextBox Passwort_Text_Eingabe;
        private GroupBox Farbe_Unter_Der_Passwort_Eingabe;
        private GroupBox Farbe_Über_Der_Account_Text_Eingabe;
        private Button Exit_Button;
        private Button Clear_Button;
        private Button Restart_Button;
        private Label Account_Text;
        private Label Passwort_Text;
        private Button Login_Button;
        private GroupBox Farbe_Oben_Im_Fenster;
        private GroupBox Farbe_Unten_Im_Fenster;
    }
}