using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace Banking
{

    public partial class Bank : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public static Bank instance; // eksportowanie formsa 
        // Loading Forms
        public Bank()
        {
            InitializeComponent();
            instance = this;

            // dataGrid
            Transactions();

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
        public void GetSettings() // Wyświetlanie informacji na temat użytkownika w user panel
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(); // Definiowanie komendy sql


            SqlCommand sqlData = new SqlCommand( 
                "SELECT FirstName, LastName, Balance FROM ATMUsers where Firstname=@firstname AND Lastname=@lastname ", connection);
            sqlData.Parameters.AddWithValue("firstname", Login.instance.FirstNameLogin.Text);
            sqlData.Parameters.AddWithValue("lastname", Login.instance.LastNameLogin.Text);

            SqlDataReader reader1;

            reader1 = sqlData.ExecuteReader();

            while (reader1.Read())
            {
                UserFirstName.Text = reader1[0].ToString();
                UserLastName.Text = reader1[1].ToString();
                UserBalance.Text = reader1[2].ToString();
            }
            connection.Close();
        }
        private void Bank_Load(object sender, EventArgs e)
        {
            GetSettings();

            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 10);
            dg1.DefaultCellStyle.Font = new Font("arial", 10);
            dg2.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 10);
            dg2.DefaultCellStyle.Font = new Font("arial", 10);
            if (UserFirstName.Text == "admin")
            {
                AdminPanelbtn.Visible = true;
            }
        }
        public void Transactions()
        
        {
            // Transactions Sent
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter();
            SqlCommand cmd = sqlData.SelectCommand = new SqlCommand("SELECT SFirstName, SLastName, RFirstName, RLastName, Amount FROM Transactions WHERE SFirstName=@sfirstname AND SLastName=@slastname", connection);
            cmd.Parameters.AddWithValue("sfirstname", Login.instance.FirstNameLogin.Text);
            cmd.Parameters.AddWithValue("slastname", Login.instance.LastNameLogin.Text);

            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;

            connection.Close();

            // Transaction Received
            connection.Open();

            SqlDataAdapter sqlData1 = new SqlDataAdapter();
            //SqlCommand firstNameQuery = new SqlCommand("SELECT * FROM Transactions WHERE SFirstName=@sfirstname AND SLastName=@slastname", connection);
            SqlCommand cmd1 = sqlData1.SelectCommand = new SqlCommand("SELECT SFirstName, SLastName, RFirstName, RLastName, Amount FROM Transactions WHERE RFirstName=@rfirstname AND RLastName=@rlastname", connection);
            cmd1.Parameters.AddWithValue("rfirstname", Login.instance.FirstNameLogin.Text);
            cmd1.Parameters.AddWithValue("rlastname", Login.instance.LastNameLogin.Text);

            DataTable dtbl1 = new DataTable();
            sqlData1.Fill(dtbl1);

            dg2.DataSource = dtbl1;
            //dg2.Columns[0].HeaderText = "Sender Name";

            connection.Close();
        }
        public void BalanceUpdate()
        {
            // Adding Money
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlQuery = new SqlCommand("UPDATE ATMUsers SET Balance+=@balance WHERE FirstName=@firstname AND LastName=@lastname", connection);
            sqlQuery.Parameters.AddWithValue("firstname", RFirstName.Text);
            sqlQuery.Parameters.AddWithValue("lastname", RLastName.Text);
            sqlQuery.Parameters.AddWithValue("balance", Amount.Text.ToString());
            sqlQuery.ExecuteNonQuery();

            connection.Close();
            // And removing from sender
            UserBalance.Text = (Convert.ToInt32(UserBalance.Text) - Convert.ToInt32(Amount.Text)).ToString();
            connection.Open();
            SqlCommand sqlQuery1 = new SqlCommand("UPDATE ATMUsers SET Balance-=@balance WHERE FirstName=@firstname AND LastName=@lastname", connection);
            sqlQuery1.Parameters.AddWithValue("firstname", UserFirstName.Text);
            sqlQuery1.Parameters.AddWithValue("lastname", UserLastName.Text);
            sqlQuery1.Parameters.AddWithValue("balance", Amount.Text.ToString());
            sqlQuery1.ExecuteNonQuery();

            connection.Close();
        }
        public bool CheckForUsers()
        {
            string FirstName = RLastName.Text;
            string LastName = RLastName.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand sqlQuery1 = new SqlCommand("SELECT * FROM ATMUsers WHERE FirstName=@firstname AND LastName=@lastname", connection);
            sqlQuery1.Parameters.AddWithValue("firstname", FirstName);
            sqlQuery1.Parameters.AddWithValue("lastname", LastName);
            SqlDataReader reader;

            reader = sqlQuery1.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
            connection.Close();
            
        }
        // Buttons
        private void AdminPanelbtn_Click(object sender, EventArgs e)
        {
            loadform(new Bank_admin());
        }
        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Send_Click(object sender, EventArgs e)
        {
            CheckForUsers();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlQuery = new SqlCommand("INSERT INTO Transactions (SFirstName, SLastName, RFirstName, RLastName, Amount) VALUES(@sfirstname,@slastname,@rfirstname,@rlastname,@amount)", connection);
            

            int parsedValue;
            if (!int.TryParse(Amount.Text, out parsedValue))
            {
                Notification.Text = "Amount has to be a number";
                Notification.Visible = true;
                return;
            }
            else
            {
                if (RFirstName.Text != "" && RLastName.Text != "" && Amount.Text != "")
                {
                    sqlQuery.Parameters.AddWithValue("sfirstname", Login.instance.FirstNameLogin.Text);
                    sqlQuery.Parameters.AddWithValue("slastname", Login.instance.LastNameLogin.Text);
                    sqlQuery.Parameters.AddWithValue("rfirstname", RFirstName.Text);
                    sqlQuery.Parameters.AddWithValue("rlastname", RLastName.Text);
                    sqlQuery.Parameters.AddWithValue("amount", Convert.ToInt32(Amount.Text));

                    if (Convert.ToInt32(UserBalance.Text) < Convert.ToInt32(Amount.Text))
                    {
                        Notification.Text = "You don't have enough money";
                        Notification.Visible = true;
                    }
                    else if (Convert.ToInt32(UserBalance.Text) == 0)
                    {
                        Notification.Text = "You don't have enough money";
                        Notification.Visible = true;
                    }
                    else if (UserFirstName.Text == RFirstName.Text && UserFirstName.Text == RLastName.Text)
                    {
                        Notification.Text = "Can't send to yourself";
                        Notification.Visible = true;
                    }
                    else if (CheckForUsers() == false)
                    {
                        Notification.Text = "Account doesn't exist";
                        Notification.Visible = true;
                    }
                    else
                    {
                        BalanceUpdate();
                        Notification.Text = "Transfer Complete";
                        Notification.Visible = true;
                        sqlQuery.ExecuteNonQuery();
                        RFirstName.Text = "";
                        RLastName.Text = "";
                        Amount.Text = "";
                        Transactions();
                    }

                    connection.Close();
                }
                else
                {
                    Notification.Text = "All fields must be filled";
                    Notification.Visible = true;
                }
            }
            
        }
    }
}
