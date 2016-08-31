using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class Authorisation : Form
    {
        private readonly string _connectionString;
        private SqlDataAdapter Adapter { get; set; }

        private DataTable Dt { get; set; }

        private bool Auth { get; set; }

        private SqlConnection Connection { get; set; }

        public Authorisation()
        {
            InitializeComponent();
            _connectionString =
                ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"]
                    .ConnectionString;
        }

        private bool Authorization()
        {
            var query = "select Count(*) from Users where Name = '" + tbUser.Text + "' and Pass = '" + tbPassword.Text +"'";
            Connection = new SqlConnection(_connectionString);
            Adapter = new SqlDataAdapter(query, Connection);
            Dt = new DataTable(); //create table from our sql variables

            Adapter.Fill(Dt);

            if (Dt.Rows[0][0].ToString() == "1")
            {
                Auth = true;
            }
            else
            {
                MessageBox.Show(@"Try againe");
            }
            return Auth;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!Authorization()) return;
            Close();
            Auth = false;
        }

        private void lnkLbNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newUser = new NewUser();
            newUser.ShowDialog();
        }
    }
}
