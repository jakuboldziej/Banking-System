namespace Banking
{
    partial class Login
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.LoginPage = new System.Windows.Forms.Label();
            this.ForgotPIN = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LastNameLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FillTheBox = new System.Windows.Forms.Label();
            this.Loginbtn1 = new System.Windows.Forms.Button();
            this.PINLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.mainmenubtn = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainMenuPanel.Controls.Add(this.panel1);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Controls.Add(this.exitbtn);
            this.MainMenuPanel.Controls.Add(this.mainmenubtn);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(900, 550);
            this.MainMenuPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.RememberMe);
            this.panel1.Controls.Add(this.LoginPage);
            this.panel1.Controls.Add(this.ForgotPIN);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.LastNameLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FillTheBox);
            this.panel1.Controls.Add(this.Loginbtn1);
            this.panel1.Controls.Add(this.PINLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FirstNameLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 465);
            this.panel1.TabIndex = 6;
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RememberMe.Location = new System.Drawing.Point(25, 266);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(132, 25);
            this.RememberMe.TabIndex = 12;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            this.RememberMe.CheckedChanged += new System.EventHandler(this.RememberMe_CheckedChanged);
            // 
            // LoginPage
            // 
            this.LoginPage.AutoSize = true;
            this.LoginPage.BackColor = System.Drawing.SystemColors.GrayText;
            this.LoginPage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LoginPage.Location = new System.Drawing.Point(366, 23);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(159, 37);
            this.LoginPage.TabIndex = 11;
            this.LoginPage.Text = "Login Page";
            // 
            // ForgotPIN
            // 
            this.ForgotPIN.AutoSize = true;
            this.ForgotPIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPIN.LinkColor = System.Drawing.Color.DarkBlue;
            this.ForgotPIN.Location = new System.Drawing.Point(141, 313);
            this.ForgotPIN.Name = "ForgotPIN";
            this.ForgotPIN.Size = new System.Drawing.Size(69, 15);
            this.ForgotPIN.TabIndex = 6;
            this.ForgotPIN.TabStop = true;
            this.ForgotPIN.Text = "Forgot PIN?";
            this.ForgotPIN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPIN_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(263, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show PIN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LastNameLogin
            // 
            this.LastNameLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LastNameLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LastNameLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.LastNameLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastNameLogin.Location = new System.Drawing.Point(141, 173);
            this.LastNameLogin.MaxLength = 32;
            this.LastNameLogin.Name = "LastNameLogin";
            this.LastNameLogin.Size = new System.Drawing.Size(105, 23);
            this.LastNameLogin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(25, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last name";
            // 
            // FillTheBox
            // 
            this.FillTheBox.AutoSize = true;
            this.FillTheBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.FillTheBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillTheBox.ForeColor = System.Drawing.Color.Red;
            this.FillTheBox.Location = new System.Drawing.Point(28, 353);
            this.FillTheBox.Name = "FillTheBox";
            this.FillTheBox.Size = new System.Drawing.Size(0, 28);
            this.FillTheBox.TabIndex = 9;
            // 
            // Loginbtn1
            // 
            this.Loginbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn1.Location = new System.Drawing.Point(25, 309);
            this.Loginbtn1.Name = "Loginbtn1";
            this.Loginbtn1.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn1.TabIndex = 5;
            this.Loginbtn1.Text = "Login";
            this.Loginbtn1.UseVisualStyleBackColor = true;
            this.Loginbtn1.Click += new System.EventHandler(this.Loginbtn1_Click);
            // 
            // PINLogin
            // 
            this.PINLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.PINLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PINLogin.Location = new System.Drawing.Point(141, 223);
            this.PINLogin.MaxLength = 4;
            this.PINLogin.Name = "PINLogin";
            this.PINLogin.PlaceholderText = "****";
            this.PINLogin.Size = new System.Drawing.Size(105, 23);
            this.PINLogin.TabIndex = 3;
            this.PINLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "PIN";
            // 
            // FirstNameLogin
            // 
            this.FirstNameLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FirstNameLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FirstNameLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.FirstNameLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FirstNameLogin.Location = new System.Drawing.Point(141, 125);
            this.FirstNameLogin.MaxLength = 32;
            this.FirstNameLogin.Name = "FirstNameLogin";
            this.FirstNameLogin.Size = new System.Drawing.Size(105, 23);
            this.FirstNameLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(418, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Location = new System.Drawing.Point(797, 29);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // mainmenubtn
            // 
            this.mainmenubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenubtn.Location = new System.Drawing.Point(28, 29);
            this.mainmenubtn.Name = "mainmenubtn";
            this.mainmenubtn.Size = new System.Drawing.Size(111, 23);
            this.mainmenubtn.TabIndex = 7;
            this.mainmenubtn.Text = "Main Menu";
            this.mainmenubtn.UseVisualStyleBackColor = true;
            this.mainmenubtn.Click += new System.EventHandler(this.mainmenubtn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel MainMenuPanel;
        private Button mainmenubtn;
        private Button exitbtn;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button Loginbtn1;
        private Label FillTheBox;
        private Label label4;
        private CheckBox checkBox1;
        public TextBox FirstNameLogin;
        public TextBox PINLogin;
        public TextBox LastNameLogin;
        private LinkLabel ForgotPIN;
        private Label LoginPage;
        private CheckBox RememberMe;
    }
}