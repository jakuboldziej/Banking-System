using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace Banking
{
    public partial class NewAccount : Form
    {
        // Loading Forms
        public NewAccount()
        {
            InitializeComponent();
        }
        public void loadform(object Form) 
        {
            MainMenuPanel.Controls.Clear(); 
            if (this.MainMenuPanel.Controls.Count > 0) // Ładowanie nowych forms
                this.MainMenuPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainMenuPanel.Controls.Add(f);
            this.MainMenuPanel.Tag = f;
            f.Show();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PIN.UseSystemPasswordChar = false;
                PINConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                PIN.UseSystemPasswordChar = true;
                PINConfirm.UseSystemPasswordChar = true;
            }
        }
        private void NewAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NewAccountBtn.PerformClick();
            }
            
        }
        // Buttons
        private void mainmenubtn_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }
        private void Login_Click(object sender, EventArgs e)
        {
            loadform(new Login());
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewAccountBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; // połączenie z bazą App.Config
            SqlConnection connection = new SqlConnection(connectionString); // Definiowanie connection do connection stringa
            SqlCommand cmd = new SqlCommand(); // Definiowanie komendy sql


            SqlCommand sqlData = new SqlCommand( // Sprawdzanie czy użytkownik już istnieje
                "SELECT FirstName FROM ATMUsers where Firstname=@firstname", connection);
            sqlData.Parameters.AddWithValue("firstname", FirstName.Text);
            SqlDataReader reader1;

            connection.Open();
            reader1 = sqlData.ExecuteReader();

            int parsedValue;
            if ((!int.TryParse(PIN.Text, out parsedValue)) || (!int.TryParse(PINConfirm.Text, out parsedValue)))
            {
                FillTheBox.Text = "PIN has to be a number";
                return;
            }
            else // Jeżeli nie istnieje idź dalej
            {
                if (FirstName.Text == "" || LastName.Text == "" || PIN.Text == "" || PINConfirm.Text == "") // Jeżeli PIN nie jest taki sam jak PIN Confirm error
                {
                    FillTheBox.Text = "All fields must be filled.";
                    connection.Close();
                }
                else
                {
                    if (PIN.Text.Length != 4) // Jeżeli PIN nie ma 4 cyfr error
                    {
                        FillTheBox.Text = "PIN must be 4-digit number.";
                        connection.Close();
                    }
                    else if (PIN.Text != PINConfirm.Text) // Jeżeli pola są puste error
                    {
                        FillTheBox.Text = "You must Confirm PIN.";
                        connection.Close();
                    }
                    else if (reader1.Read()) // Sprawdzanie czy użytkownik już istnieje
                    {
                        FillTheBox.Text = "Account already exists.";
                        connection.Close();
                    }
                    else // jeżeli wypełnione dodaj użytkownika do bazy danych 
                    {
                        connection.Close();
                        connection.Open();
                        int balance = 0;
                        string sqlQuery = "INSERT INTO ATMUsers (FirstName, LastName, PIN, Balance)  VALUES(" + "'" + FirstName.Text.Trim() + "','" + LastName.Text.Trim() + "','" + PIN.Text.Trim() + "','" + balance + "'" + ")"; // SQL Query
                        cmd = new SqlCommand(sqlQuery, connection);
                        cmd.ExecuteNonQuery();
                        FillTheBox.Text = "Created new account.";
                        Login.Visible = true;
                        connection.Close();
                    }
                }

                connection.Close();
            }





        }
        private void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            PIN.Text = "";
            PINConfirm.Text = "";
        }
    }

}
