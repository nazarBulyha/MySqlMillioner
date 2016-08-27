using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class NewUser : Form
    {
        string connectionString;
        string query;
        SqlCommand cmd;
        SqlConnection connection;

        public NewUser()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"].ConnectionString;
            query = "insert into Users(Name, NickName, Pass) values (@Name, @NickName, @Pass)";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Insert();
        }
        private void Insert()
        {
            if (tbNewPassword.Text == tbReapPassword.Text)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    cmd = new SqlCommand(query, connection);

                    connection.Open();
                    cmd.Parameters.AddWithValue("@Name", tbNewName.Text);
                    cmd.Parameters.AddWithValue("@NickName", tbNickName.Text);
                    cmd.Parameters.AddWithValue("@Pass", tbNewPassword.Text);
                    cmd.ExecuteNonQuery();
                    Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Check your password!");
            }
        }
    }
}

    
