using System;

namespace Banking
{
    public partial class Form1 : Form
    {
        // Loading Forms
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form) // funkcja do przechodzenia pomiêdzy oknami
        {
            MainMenuPanel.Controls.Clear();
            if (this.MainMenuPanel.Controls.Count > 0)
                this.MainMenuPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainMenuPanel.Controls.Add(f);
            this.MainMenuPanel.Tag = f;
            f.Show();
        }
        // Buttons
        private void loginbtn_Click(object sender, EventArgs e)
        {
            loadform(new Login());
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void newAccountbtn_Click(object sender, EventArgs e)
        {
            loadform(new NewAccount());
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                exitbtn.PerformClick();
            }
        }
    }
}