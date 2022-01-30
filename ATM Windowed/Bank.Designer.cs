namespace Banking
{
    partial class Bank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.Notification = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Send = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.UserLastName = new System.Windows.Forms.Label();
            this.UserFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FillTheBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.AdminPanelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.Notification);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.UserLastName);
            this.panel1.Controls.Add(this.UserFirstName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UserBalance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FillTheBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 465);
            this.panel1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dg2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 187);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received";
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(0, 33);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowTemplate.Height = 25;
            this.dg2.RowTemplate.ReadOnly = true;
            this.dg2.Size = new System.Drawing.Size(554, 151);
            this.dg2.TabIndex = 0;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.BackColor = System.Drawing.SystemColors.GrayText;
            this.Notification.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Notification.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Notification.Location = new System.Drawing.Point(578, 404);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(169, 28);
            this.Notification.TabIndex = 19;
            this.Notification.Text = "Transfer Complete";
            this.Notification.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Send);
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.RLastName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RFirstName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(563, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 259);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer";
            // 
            // Send
            // 
            this.Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Send.Location = new System.Drawing.Point(16, 187);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(54, 36);
            this.Send.TabIndex = 17;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Amount
            // 
            this.Amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Amount.BackColor = System.Drawing.SystemColors.GrayText;
            this.Amount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Amount.Location = new System.Drawing.Point(211, 133);
            this.Amount.MaxLength = 10;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(105, 34);
            this.Amount.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(15, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount";
            // 
            // RLastName
            // 
            this.RLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RLastName.BackColor = System.Drawing.SystemColors.GrayText;
            this.RLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RLastName.Location = new System.Drawing.Point(211, 90);
            this.RLastName.MaxLength = 32;
            this.RLastName.Name = "RLastName";
            this.RLastName.Size = new System.Drawing.Size(105, 34);
            this.RLastName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Receiver last name";
            // 
            // RFirstName
            // 
            this.RFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.RFirstName.BackColor = System.Drawing.SystemColors.GrayText;
            this.RFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RFirstName.Location = new System.Drawing.Point(211, 39);
            this.RFirstName.MaxLength = 32;
            this.RFirstName.Name = "RFirstName";
            this.RFirstName.Size = new System.Drawing.Size(105, 34);
            this.RFirstName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Receiver name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 187);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sent";
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(0, 29);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 25;
            this.dg1.Size = new System.Drawing.Size(554, 158);
            this.dg1.TabIndex = 0;
            // 
            // UserLastName
            // 
            this.UserLastName.AutoSize = true;
            this.UserLastName.BackColor = System.Drawing.SystemColors.GrayText;
            this.UserLastName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLastName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UserLastName.Location = new System.Drawing.Point(120, 62);
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.Size = new System.Drawing.Size(0, 28);
            this.UserLastName.TabIndex = 16;
            // 
            // UserFirstName
            // 
            this.UserFirstName.AutoSize = true;
            this.UserFirstName.BackColor = System.Drawing.SystemColors.GrayText;
            this.UserFirstName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserFirstName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UserFirstName.Location = new System.Drawing.Point(85, 14);
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.Size = new System.Drawing.Size(0, 28);
            this.UserFirstName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // UserBalance
            // 
            this.UserBalance.AutoSize = true;
            this.UserBalance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserBalance.Location = new System.Drawing.Point(816, 21);
            this.UserBalance.Name = "UserBalance";
            this.UserBalance.Size = new System.Drawing.Size(0, 28);
            this.UserBalance.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(728, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Balance";
            // 
            // FillTheBox
            // 
            this.FillTheBox.AutoSize = true;
            this.FillTheBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.FillTheBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillTheBox.ForeColor = System.Drawing.Color.Red;
            this.FillTheBox.Location = new System.Drawing.Point(34, 220);
            this.FillTheBox.Name = "FillTheBox";
            this.FillTheBox.Size = new System.Drawing.Size(0, 28);
            this.FillTheBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(366, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Panel";
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainMenuPanel.Controls.Add(this.AdminPanelbtn);
            this.MainMenuPanel.Controls.Add(this.panel1);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Controls.Add(this.exitbtn);
            this.MainMenuPanel.Controls.Add(this.LogOutbtn);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(900, 550);
            this.MainMenuPanel.TabIndex = 3;
            // 
            // AdminPanelbtn
            // 
            this.AdminPanelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPanelbtn.Location = new System.Drawing.Point(155, 29);
            this.AdminPanelbtn.Name = "AdminPanelbtn";
            this.AdminPanelbtn.Size = new System.Drawing.Size(111, 23);
            this.AdminPanelbtn.TabIndex = 7;
            this.AdminPanelbtn.Text = "Admin Panel";
            this.AdminPanelbtn.UseVisualStyleBackColor = true;
            this.AdminPanelbtn.Visible = false;
            this.AdminPanelbtn.Click += new System.EventHandler(this.AdminPanelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(404, 24);
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
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutbtn.Location = new System.Drawing.Point(28, 29);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(111, 23);
            this.LogOutbtn.TabIndex = 0;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label FillTheBox;
        private Label label2;
        private Panel MainMenuPanel;
        private Label label1;
        private Button exitbtn;
        private Button LogOutbtn;
        private Label label3;
        private Label UserBalance;
        private Label UserLastName;
        private Label UserFirstName;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dg1;
        public TextBox Amount;
        private Label label8;
        public TextBox RLastName;
        private Label label6;
        public TextBox RFirstName;
        private Label label7;
        private Button Send;
        private Label Notification;
        private Button AdminPanelbtn;
        private GroupBox groupBox3;
        private DataGridView dg2;
    }
}