using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class Authorisation : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public Authorisation()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"].ConnectionString;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void Auth()
        {
            string query = "select Count(*) from Users where Name = '" + tbUser.Text + "' and Pass = '" + tbPassword.Text + "'";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter(query, connection);
            dt = new DataTable();//create table from our sql variables

            adapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Try againe");
            }
        }

        private void lnkLbNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
        }
    }
}
