using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Banking
{
    public partial class Bank_admin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        // Loading Forms
        public Bank_admin()
        {
            InitializeComponent();

            LoadingDg1();
            LoadingDg2();
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
        public void LoadingDg1()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ATMUsers", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;

            int count = dg1.RowCount - 1;
            UserCount.Text = "User Count " + count.ToString();
            connection.Close();
        }
        public void LoadingDg2()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transactions", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;

            int count = dg2.RowCount - 1;
            TransactionCount.Text = "Transaction Count " + count.ToString();
            connection.Close();
        }
        // Buttons
        private void mainmenubtn_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            LoadingDg1();
            LoadingDg2();
        }
        private void UserPanelbtn_Click(object sender, EventArgs e)
        {
            loadform(new Bank());
        }

        // DataGrid Action Buttons
        // Users
        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("DELETE FROM ATMUsers WHERE ID NOT IN (1)", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;

            connection.Close();
            MessageBox.Show("Delete complete");
        }
        private void OrderByName_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ATMUsers ORDER BY FirstName ASC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        private void OrderByNameReverse_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ATMUsers ORDER BY FirstName DESC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        private void OrderByBalance_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ATMUsers ORDER BY Balance DESC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        private void OrderByBalanceReverse_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM ATMUsers ORDER BY Balance ASC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        private void DeleteDuplicates_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter(
                "DELETE FROM [Users].[dbo].[ATMUsers]" + "WHERE ID NOT IN" + "(" + "SELECT MAX(ID)" + "FROM[Users].[dbo].[ATMUsers]" + "GROUP BY[FirstName]," + "[LastName]" + ");", connection);

            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("DELETE FROM ATMUsers WHERE FirstName = '" + FirstNameDelete.Text.Trim() + "' AND LastName = '" + LastNameDelete.Text.Trim() + "'", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();

            FirstNameDelete.Text = "";
            LastNameDelete.Text = "";
        }
        private void AddBalanceBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query = "UPDATE ATMUsers SET Balance=@balance WHERE FirstName=@firstname AND LastName=@lastname";
            SqlCommand cmd = new SqlCommand(query, connection);

            int balanceAmount = int.Parse(BalanceAmount.Text);
            cmd.Parameters.AddWithValue("balance", Convert.ToInt32(balanceAmount));
            cmd.Parameters.AddWithValue("firstname", FirstNameAdd.Text);
            cmd.Parameters.AddWithValue("lastname", LastNameAdd.Text);
            cmd.ExecuteNonQuery();

            connection.Close();
            FirstNameAdd.Text = "";
            LastNameAdd.Text = "";
            BalanceAmount.Text = "";

            MessageBox.Show("Adding balance complete");

        }
        private void ResetPrimaryKeyUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("DBCC CHECKIDENT ('ATMUsers', RESEED, 0);", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg1.DataSource = dtbl;
            connection.Close();
        }
        // Transactions
        private void DeleteTransactions_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("DELETE FROM Transactions", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;

            connection.Close();
        }
        private void ResetPrimaryKeyTransactions_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("DBCC CHECKIDENT ('Transactions', RESEED, 0);", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;
            connection.Close();
        }
        private void OBSN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transactions ORDER BY SFirstName ASC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;
            connection.Close();
        }
        private void OBRN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transactions ORDER BY RFirstName ASC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;
            connection.Close();
        }
        private void OBHA_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transactions ORDER BY Amount DESC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;
            connection.Close();
        }
        private void OBLA_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Transactions ORDER BY Amount ASC", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dg2.DataSource = dtbl;
            connection.Close();
        }
    }
}
