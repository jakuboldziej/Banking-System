namespace Banking
{
    partial class NewAccount
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
            this.LoginPage = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.FillTheBox = new System.Windows.Forms.Label();
            this.PINConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NewAccountBtn = new System.Windows.Forms.Button();
            this.PIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
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
            this.MainMenuPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.LoginPage);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.FillTheBox);
            this.panel1.Controls.Add(this.PINConfirm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.NewAccountBtn);
            this.panel1.Controls.Add(this.PIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 465);
            this.panel1.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.LoginPage.AutoSize = true;
            this.LoginPage.BackColor = System.Drawing.SystemColors.GrayText;
            this.LoginPage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LoginPage.Location = new System.Drawing.Point(358, 25);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(187, 37);
            this.LoginPage.TabIndex = 18;
            this.LoginPage.Text = "Sign Up Page";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(274, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show PIN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.Location = new System.Drawing.Point(171, 322);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Location = new System.Drawing.Point(27, 412);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Visible = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // FillTheBox
            // 
            this.FillTheBox.AutoSize = true;
            this.FillTheBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.FillTheBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillTheBox.ForeColor = System.Drawing.Color.Red;
            this.FillTheBox.Location = new System.Drawing.Point(28, 364);
            this.FillTheBox.Name = "FillTheBox";
            this.FillTheBox.Size = new System.Drawing.Size(0, 28);
            this.FillTheBox.TabIndex = 14;
            // 
            // PINConfirm
            // 
            this.PINConfirm.BackColor = System.Drawing.SystemColors.GrayText;
            this.PINConfirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PINConfirm.Location = new System.Drawing.Point(151, 271);
            this.PINConfirm.MaxLength = 4;
            this.PINConfirm.Name = "PINConfirm";
            this.PINConfirm.PlaceholderText = "****";
            this.PINConfirm.Size = new System.Drawing.Size(105, 23);
            this.PINConfirm.TabIndex = 4;
            this.PINConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(25, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm PIN";
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.GrayText;
            this.LastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastName.Location = new System.Drawing.Point(151, 173);
            this.LastName.MaxLength = 32;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(105, 23);
            this.LastName.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.SystemColors.GrayText;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastNameLabel.Location = new System.Drawing.Point(25, 168);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 28);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last name";
            // 
            // NewAccountBtn
            // 
            this.NewAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewAccountBtn.Location = new System.Drawing.Point(27, 322);
            this.NewAccountBtn.Name = "NewAccountBtn";
            this.NewAccountBtn.Size = new System.Drawing.Size(121, 23);
            this.NewAccountBtn.TabIndex = 5;
            this.NewAccountBtn.Text = "Create new account";
            this.NewAccountBtn.UseVisualStyleBackColor = true;
            this.NewAccountBtn.Click += new System.EventHandler(this.NewAccountBtn_Click);
            // 
            // PIN
            // 
            this.PIN.BackColor = System.Drawing.SystemColors.GrayText;
            this.PIN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PIN.Location = new System.Drawing.Point(151, 223);
            this.PIN.MaxLength = 4;
            this.PIN.Name = "PIN";
            this.PIN.PlaceholderText = "****";
            this.PIN.Size = new System.Drawing.Size(105, 23);
            this.PIN.TabIndex = 3;
            this.PIN.UseSystemPasswordChar = true;
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
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.GrayText;
            this.FirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FirstName.Location = new System.Drawing.Point(151, 125);
            this.FirstName.MaxLength = 32;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(105, 23);
            this.FirstName.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(417, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATM";
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Location = new System.Drawing.Point(797, 29);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 9;
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
            this.mainmenubtn.TabIndex = 8;
            this.mainmenubtn.Text = "Main Menu";
            this.mainmenubtn.UseVisualStyleBackColor = true;
            this.mainmenubtn.Click += new System.EventHandler(this.mainmenubtn_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewAccount_KeyDown);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox PIN;
        private Label label3;
        private TextBox FirstName;
        private Label label2;
        private Panel MainMenuPanel;
        private Label label1;
        private Button exitbtn;
        private Button mainmenubtn;
        private TextBox textBox4;
        private Label label5;
        private TextBox PINConfirm;
        private Label label4;
        private TextBox LastName;
        private Label LastNameLabel;
        private Button NewAccountBtn;
        private Label FillTheBox;
        private Button Login;
        private Button Clear;
        private CheckBox checkBox1;
        private Label LoginPage;
    }
}