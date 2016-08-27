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
        User user;

        public NewUser()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"].ConnectionString;
            query = "insert into Users(Name, NickName, Pass) values (@Name, @NickName, @Pass)";

            user = new User();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            user.NewName = tbNewName.Text;
            user.NickName = tbNickName.Text;
            user.Password = tbNewPassword.Text;

            Insert();
        }
        public void Insert()
        {
            if (tbNewPassword.Text == tbReapPassword.Text)
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    cmd = new SqlCommand(query, connection);

                    connection.Open();
                    cmd.Parameters.AddWithValue("@Name", user.NewName);
                    cmd.Parameters.AddWithValue("@NickName", user.NickName);
                    cmd.Parameters.AddWithValue("@Pass", user.Password);
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

    
