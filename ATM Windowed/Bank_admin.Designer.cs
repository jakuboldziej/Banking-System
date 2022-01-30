namespace Banking
{
    partial class Bank_admin
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
            this.OBLA = new System.Windows.Forms.Button();
            this.OBHA = new System.Windows.Forms.Button();
            this.OBRN = new System.Windows.Forms.Button();
            this.OBSN = new System.Windows.Forms.Button();
            this.ResetPrimaryKeyTransactions = new System.Windows.Forms.Button();
            this.ResetPrimaryKeyUser = new System.Windows.Forms.Button();
            this.DeleteTransactions = new System.Windows.Forms.Button();
            this.TransactionCount = new System.Windows.Forms.Label();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.OrderByBalanceReverse = new System.Windows.Forms.Button();
            this.OrderByBalance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LastNameDelete = new System.Windows.Forms.TextBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstNameDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BalanceAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBalanceBtn = new System.Windows.Forms.Button();
            this.LastNameAdd = new System.Windows.Forms.TextBox();
            this.FirstNameAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteDuplicates = new System.Windows.Forms.Button();
            this.UserCount = new System.Windows.Forms.Label();
            this.OrderByNameReverse = new System.Windows.Forms.Button();
            this.OrderByName = new System.Windows.Forms.Button();
            this.DeleteUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.FillTheBox = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.UserPanelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.mainmenubtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.OBLA);
            this.panel1.Controls.Add(this.OBHA);
            this.panel1.Controls.Add(this.OBRN);
            this.panel1.Controls.Add(this.OBSN);
            this.panel1.Controls.Add(this.ResetPrimaryKeyTransactions);
            this.panel1.Controls.Add(this.ResetPrimaryKeyUser);
            this.panel1.Controls.Add(this.DeleteTransactions);
            this.panel1.Controls.Add(this.TransactionCount);
            this.panel1.Controls.Add(this.dg2);
            this.panel1.Controls.Add(this.OrderByBalanceReverse);
            this.panel1.Controls.Add(this.OrderByBalance);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DeleteDuplicates);
            this.panel1.Controls.Add(this.UserCount);
            this.panel1.Controls.Add(this.OrderByNameReverse);
            this.panel1.Controls.Add(this.OrderByName);
            this.panel1.Controls.Add(this.DeleteUsers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dg1);
            this.panel1.Controls.Add(this.FillTheBox);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 468);
            this.panel1.TabIndex = 6;
            // 
            // OBLA
            // 
            this.OBLA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OBLA.Location = new System.Drawing.Point(457, 364);
            this.OBLA.Name = "OBLA";
            this.OBLA.Size = new System.Drawing.Size(105, 43);
            this.OBLA.TabIndex = 43;
            this.OBLA.Text = "Order By Lowest Amount";
            this.OBLA.UseVisualStyleBackColor = true;
            this.OBLA.Click += new System.EventHandler(this.OBLA_Click);
            // 
            // OBHA
            // 
            this.OBHA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OBHA.Location = new System.Drawing.Point(346, 364);
            this.OBHA.Name = "OBHA";
            this.OBHA.Size = new System.Drawing.Size(105, 43);
            this.OBHA.TabIndex = 42;
            this.OBHA.Text = "Order By Highest Amount";
            this.OBHA.UseVisualStyleBackColor = true;
            this.OBHA.Click += new System.EventHandler(this.OBHA_Click);
            // 
            // OBRN
            // 
            this.OBRN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OBRN.Location = new System.Drawing.Point(443, 315);
            this.OBRN.Name = "OBRN";
            this.OBRN.Size = new System.Drawing.Size(94, 43);
            this.OBRN.TabIndex = 41;
            this.OBRN.Text = "Order By Receiver Name";
            this.OBRN.UseVisualStyleBackColor = true;
            this.OBRN.Click += new System.EventHandler(this.OBRN_Click);
            // 
            // OBSN
            // 
            this.OBSN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OBSN.Location = new System.Drawing.Point(346, 315);
            this.OBSN.Name = "OBSN";
            this.OBSN.Size = new System.Drawing.Size(91, 43);
            this.OBSN.TabIndex = 40;
            this.OBSN.Text = "Order By Sender Name";
            this.OBSN.UseVisualStyleBackColor = true;
            this.OBSN.Click += new System.EventHandler(this.OBSN_Click);
            // 
            // ResetPrimaryKeyTransactions
            // 
            this.ResetPrimaryKeyTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPrimaryKeyTransactions.Location = new System.Drawing.Point(345, 418);
            this.ResetPrimaryKeyTransactions.Name = "ResetPrimaryKeyTransactions";
            this.ResetPrimaryKeyTransactions.Size = new System.Drawing.Size(78, 38);
            this.ResetPrimaryKeyTransactions.TabIndex = 39;
            this.ResetPrimaryKeyTransactions.Text = "Reset Primary Key";
            this.ResetPrimaryKeyTransactions.UseVisualStyleBackColor = true;
            this.ResetPrimaryKeyTransactions.Click += new System.EventHandler(this.ResetPrimaryKeyTransactions_Click);
            // 
            // ResetPrimaryKeyUser
            // 
            this.ResetPrimaryKeyUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPrimaryKeyUser.Location = new System.Drawing.Point(345, 210);
            this.ResetPrimaryKeyUser.Name = "ResetPrimaryKeyUser";
            this.ResetPrimaryKeyUser.Size = new System.Drawing.Size(78, 38);
            this.ResetPrimaryKeyUser.TabIndex = 38;
            this.ResetPrimaryKeyUser.Text = "Reset Primary Key";
            this.ResetPrimaryKeyUser.UseVisualStyleBackColor = true;
            this.ResetPrimaryKeyUser.Click += new System.EventHandler(this.ResetPrimaryKeyUser_Click);
            // 
            // DeleteTransactions
            // 
            this.DeleteTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTransactions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteTransactions.Location = new System.Drawing.Point(429, 418);
            this.DeleteTransactions.Name = "DeleteTransactions";
            this.DeleteTransactions.Size = new System.Drawing.Size(71, 39);
            this.DeleteTransactions.TabIndex = 37;
            this.DeleteTransactions.Text = "Delete All Transactions";
            this.DeleteTransactions.UseVisualStyleBackColor = true;
            this.DeleteTransactions.Click += new System.EventHandler(this.DeleteTransactions_Click);
            // 
            // TransactionCount
            // 
            this.TransactionCount.AutoSize = true;
            this.TransactionCount.BackColor = System.Drawing.SystemColors.GrayText;
            this.TransactionCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TransactionCount.Location = new System.Drawing.Point(9, 263);
            this.TransactionCount.Name = "TransactionCount";
            this.TransactionCount.Size = new System.Drawing.Size(172, 28);
            this.TransactionCount.TabIndex = 36;
            this.TransactionCount.Text = "Transaction Count:";
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(0, 309);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowTemplate.Height = 25;
            this.dg2.Size = new System.Drawing.Size(327, 159);
            this.dg2.TabIndex = 35;
            // 
            // OrderByBalanceReverse
            // 
            this.OrderByBalanceReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderByBalanceReverse.Location = new System.Drawing.Point(416, 116);
            this.OrderByBalanceReverse.Name = "OrderByBalanceReverse";
            this.OrderByBalanceReverse.Size = new System.Drawing.Size(105, 43);
            this.OrderByBalanceReverse.TabIndex = 34;
            this.OrderByBalanceReverse.Text = "Order By Balance Reverse";
            this.OrderByBalanceReverse.UseVisualStyleBackColor = true;
            this.OrderByBalanceReverse.Click += new System.EventHandler(this.OrderByBalanceReverse_Click);
            // 
            // OrderByBalance
            // 
            this.OrderByBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderByBalance.Location = new System.Drawing.Point(345, 116);
            this.OrderByBalance.Name = "OrderByBalance";
            this.OrderByBalance.Size = new System.Drawing.Size(63, 43);
            this.OrderByBalance.TabIndex = 33;
            this.OrderByBalance.Text = "Order By Balance";
            this.OrderByBalance.UseVisualStyleBackColor = true;
            this.OrderByBalance.Click += new System.EventHandler(this.OrderByBalance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LastNameDelete);
            this.groupBox2.Controls.Add(this.DeleteUser);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.FirstNameDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(632, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 217);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete User";
            // 
            // LastNameDelete
            // 
            this.LastNameDelete.BackColor = System.Drawing.SystemColors.GrayText;
            this.LastNameDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastNameDelete.Location = new System.Drawing.Point(142, 93);
            this.LastNameDelete.MaxLength = 32;
            this.LastNameDelete.Name = "LastNameDelete";
            this.LastNameDelete.Size = new System.Drawing.Size(105, 34);
            this.LastNameDelete.TabIndex = 21;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteUser.Location = new System.Drawing.Point(26, 148);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(88, 36);
            this.DeleteUser.TabIndex = 26;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(26, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name";
            // 
            // FirstNameDelete
            // 
            this.FirstNameDelete.BackColor = System.Drawing.SystemColors.GrayText;
            this.FirstNameDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FirstNameDelete.Location = new System.Drawing.Point(142, 45);
            this.FirstNameDelete.MaxLength = 32;
            this.FirstNameDelete.Name = "FirstNameDelete";
            this.FirstNameDelete.Size = new System.Drawing.Size(105, 34);
            this.FirstNameDelete.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BalanceAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddBalanceBtn);
            this.groupBox1.Controls.Add(this.LastNameAdd);
            this.groupBox1.Controls.Add(this.FirstNameAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(632, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 248);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Balance Of User";
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.BackColor = System.Drawing.SystemColors.GrayText;
            this.BalanceAmount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BalanceAmount.Location = new System.Drawing.Point(134, 138);
            this.BalanceAmount.MaxLength = 32;
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.Size = new System.Drawing.Size(105, 34);
            this.BalanceAmount.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Balance";
            // 
            // AddBalanceBtn
            // 
            this.AddBalanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBalanceBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBalanceBtn.Location = new System.Drawing.Point(26, 191);
            this.AddBalanceBtn.Name = "AddBalanceBtn";
            this.AddBalanceBtn.Size = new System.Drawing.Size(99, 36);
            this.AddBalanceBtn.TabIndex = 37;
            this.AddBalanceBtn.Text = "Add Balance";
            this.AddBalanceBtn.UseVisualStyleBackColor = true;
            this.AddBalanceBtn.Click += new System.EventHandler(this.AddBalanceBtn_Click);
            // 
            // LastNameAdd
            // 
            this.LastNameAdd.BackColor = System.Drawing.SystemColors.GrayText;
            this.LastNameAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastNameAdd.Location = new System.Drawing.Point(133, 89);
            this.LastNameAdd.MaxLength = 32;
            this.LastNameAdd.Name = "LastNameAdd";
            this.LastNameAdd.Size = new System.Drawing.Size(105, 34);
            this.LastNameAdd.TabIndex = 33;
            // 
            // FirstNameAdd
            // 
            this.FirstNameAdd.BackColor = System.Drawing.SystemColors.GrayText;
            this.FirstNameAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FirstNameAdd.Location = new System.Drawing.Point(133, 43);
            this.FirstNameAdd.MaxLength = 32;
            this.FirstNameAdd.Name = "FirstNameAdd";
            this.FirstNameAdd.Size = new System.Drawing.Size(105, 34);
            this.FirstNameAdd.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Last name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GrayText;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(18, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Name";
            // 
            // DeleteDuplicates
            // 
            this.DeleteDuplicates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDuplicates.Location = new System.Drawing.Point(417, 165);
            this.DeleteDuplicates.Name = "DeleteDuplicates";
            this.DeleteDuplicates.Size = new System.Drawing.Size(104, 39);
            this.DeleteDuplicates.TabIndex = 18;
            this.DeleteDuplicates.Text = "Delete Duplicate Users";
            this.DeleteDuplicates.UseVisualStyleBackColor = true;
            this.DeleteDuplicates.Click += new System.EventHandler(this.DeleteDuplicates_Click_1);
            // 
            // UserCount
            // 
            this.UserCount.AutoSize = true;
            this.UserCount.BackColor = System.Drawing.SystemColors.GrayText;
            this.UserCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserCount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UserCount.Location = new System.Drawing.Point(9, 16);
            this.UserCount.Name = "UserCount";
            this.UserCount.Size = new System.Drawing.Size(113, 28);
            this.UserCount.TabIndex = 16;
            this.UserCount.Text = "User Count:";
            // 
            // OrderByNameReverse
            // 
            this.OrderByNameReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderByNameReverse.Location = new System.Drawing.Point(416, 67);
            this.OrderByNameReverse.Name = "OrderByNameReverse";
            this.OrderByNameReverse.Size = new System.Drawing.Size(105, 43);
            this.OrderByNameReverse.TabIndex = 14;
            this.OrderByNameReverse.Text = "Order By Name\r\nReverse\r\n";
            this.OrderByNameReverse.UseVisualStyleBackColor = true;
            this.OrderByNameReverse.Click += new System.EventHandler(this.OrderByNameReverse_Click);
            // 
            // OrderByName
            // 
            this.OrderByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderByName.Location = new System.Drawing.Point(345, 67);
            this.OrderByName.Name = "OrderByName";
            this.OrderByName.Size = new System.Drawing.Size(63, 43);
            this.OrderByName.TabIndex = 13;
            this.OrderByName.Text = "Order By Name";
            this.OrderByName.UseVisualStyleBackColor = true;
            this.OrderByName.Click += new System.EventHandler(this.OrderByName_Click);
            // 
            // DeleteUsers
            // 
            this.DeleteUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteUsers.Location = new System.Drawing.Point(345, 165);
            this.DeleteUsers.Name = "DeleteUsers";
            this.DeleteUsers.Size = new System.Drawing.Size(63, 39);
            this.DeleteUsers.TabIndex = 12;
            this.DeleteUsers.Text = "Delete All Users";
            this.DeleteUsers.UseVisualStyleBackColor = true;
            this.DeleteUsers.Click += new System.EventHandler(this.DeleteUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(382, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Panel";
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(0, 67);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowTemplate.Height = 25;
            this.dg1.Size = new System.Drawing.Size(327, 181);
            this.dg1.TabIndex = 10;
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
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Location = new System.Drawing.Point(282, 29);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainMenuPanel.Controls.Add(this.UserPanelbtn);
            this.MainMenuPanel.Controls.Add(this.panel1);
            this.MainMenuPanel.Controls.Add(this.label1);
            this.MainMenuPanel.Controls.Add(this.exitbtn);
            this.MainMenuPanel.Controls.Add(this.mainmenubtn);
            this.MainMenuPanel.Controls.Add(this.refresh);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(900, 550);
            this.MainMenuPanel.TabIndex = 4;
            // 
            // UserPanelbtn
            // 
            this.UserPanelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPanelbtn.Location = new System.Drawing.Point(155, 29);
            this.UserPanelbtn.Name = "UserPanelbtn";
            this.UserPanelbtn.Size = new System.Drawing.Size(111, 23);
            this.UserPanelbtn.TabIndex = 7;
            this.UserPanelbtn.Text = "User Panel";
            this.UserPanelbtn.UseVisualStyleBackColor = true;
            this.UserPanelbtn.Click += new System.EventHandler(this.UserPanelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(416, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATM";
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitbtn.Location = new System.Drawing.Point(797, 29);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
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
            this.mainmenubtn.TabIndex = 0;
            this.mainmenubtn.Text = "Log Out";
            this.mainmenubtn.UseVisualStyleBackColor = true;
            this.mainmenubtn.Click += new System.EventHandler(this.mainmenubtn_Click);
            // 
            // Bank_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.MainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bank_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Button mainmenubtn;
        private BindingSource bindingSource1;
        private DataGridView dg1;
        private Button refresh;
        private Button DeleteUsers;
        private Button OrderByName;
        private Button OrderByNameReverse;
        private Label UserCount;
        private Button DeleteDuplicates;
        public TextBox LastNameDelete;
        private Label label5;
        public TextBox FirstNameDelete;
        private Label label7;
        private Button DeleteUser;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        public TextBox LastNameAdd;
        public TextBox FirstNameAdd;
        private Label label6;
        private Label label8;
        private Button AddBalanceBtn;
        public TextBox BalanceAmount;
        private Label label3;
        private Button OrderByBalanceReverse;
        private Button OrderByBalance;
        private Button UserPanelbtn;
        private DataGridView dg2;
        private Label TransactionCount;
        private Button DeleteTransactions;
        private Button ResetPrimaryKeyTransactions;
        private Button ResetPrimaryKeyUser;
        private Button OBLA;
        private Button OBHA;
        private Button OBRN;
        private Button OBSN;
    }
}