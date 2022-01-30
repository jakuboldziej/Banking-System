using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Banking
{
    public partial class Login : Form
    {
        public static Login instance; // przesyłanie danych pomiędzy formsami
        public TextBox FNLogin;
        public TextBox LNLogin;

        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection(); // automatyczne uzupełnianie textboxa
        // Loading Forms
        public Login()
        {
            InitializeComponent();
            instance = this;
            FNLogin = FirstNameLogin;
            LNLogin = LastNameLogin;
        }
        public void loadform(object Form)
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
        // Others
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PINLogin.UseSystemPasswordChar = false;
            }
            else
            {
                PINLogin.UseSystemPasswordChar = true;
            }
        }
        public void Login_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Loginbtn1.PerformClick();
            //}
            if (e.KeyCode == Keys.Escape)
            {
                mainmenubtn.PerformClick();
            }
        }
        private void ForgotPIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FillTheBox.Text = "Unlucky";
        }
        public void GetSettings() // Odczytywanie danych w ustawieniach aplikacji jeżeli użytkowni zgodzi się na zapamiętanie
        {
            FirstNameLogin.Text = Properties.Settings1.Default.FirstName;
            LastNameLogin.Text = Properties.Settings1.Default.LastName;
            RememberMe.Checked = Properties.Settings1.Default.RememberMe;
        }
        public void SaveSettings() // Zapisywanie danych w ustawieniach aplikacji jeżeli użytkowni zgodzi się na zapamiętanie
        {
            Properties.Settings1.Default.FirstName = FirstNameLogin.Text;
            Properties.Settings1.Default.LastName = LastNameLogin.Text;
            Properties.Settings1.Default.RememberMe = RememberMe.Checked;

            Properties.Settings1.Default.Save();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            GetSettings();


            // Auto sugestja z bazą danych
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; // połączenie z bazą App.Config
            SqlConnection connection = new SqlConnection(connectionString); // Definiowanie connection do connection stringa
            try   // firstname autocomplete
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                connection.Open();

                string query = "SELECT FirstName FROM ATMUsers"; 
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    col.Add(reader["FirstName"].ToString());
                }
                reader.Close();
                FirstNameLogin.AutoCompleteCustomSource = col;

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try   // lastname autocomplete
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                connection.Open();

                string query1 = "SELECT LastName FROM ATMUsers"; 
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    col.Add(reader1["LastName"].ToString());
                }

                reader1.Close();
                LastNameLogin.AutoCompleteCustomSource = col;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RememberMe.Checked == true)
            {
                SaveSettings();
            }
            else
            {
                Properties.Settings1.Default.Reset();
            }
        }
        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (RememberMe.Checked == true)
            {
                SaveSettings();
            }
            else
            {
                Properties.Settings1.Default.Reset();
            }
        }
        // Buttons
        private void mainmenubtn_Click_1(object sender, EventArgs e)
        {
            loadform(new Form1());
            if (RememberMe.Checked == true)
            {
                SaveSettings();
            }
            else
            {
                Properties.Settings1.Default.Reset();
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Loginbtn1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            int parsedValue;
            if (!int.TryParse(PINLogin.Text, out parsedValue))
            {
                FillTheBox.Text = "PIN has to be a number";
                return;
            }
            else
            {
                if (FirstNameLogin.Text != "" && LastNameLogin.Text != "" && PINLogin.Text != "")
                {

                    connection.Open();
                    string sqlQuery1 = "Select * FROM ATMUsers WHERE FirstName = '" + FirstNameLogin.Text.Trim() + "' AND LastName = '" + LastNameLogin.Text.Trim() + "' AND PIN = '" + PINLogin.Text.Trim() + "'";
                    cmd = new SqlCommand(sqlQuery1, connection);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        if (FirstNameLogin.Text == "admin" && LastNameLogin.Text == "admin")
                        {
                            FillTheBox.Text = "Logged In as Admin.";
                            loadform(new Bank_admin());
                        }
                        else
                        {
                            FillTheBox.Text = "Logged In.";
                            if (RememberMe.Checked == true)
                            {
                                SaveSettings();
                            }
                            else
                            {
                                Properties.Settings1.Default.Reset();
                            }
                            loadform(new Bank());
                        }
                    }
                    else
                    {
                        FillTheBox.Text = "Invalid login information.";
                    }
                }
                else
                {
                    FillTheBox.Text = "All fields must be filled.";
                }
                connection.Close();
            }
            
        }   
    }
}
