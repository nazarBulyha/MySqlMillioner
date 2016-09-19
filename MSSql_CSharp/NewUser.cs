using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class NewUser : Form
    {
        private readonly string _connectionString;
        private readonly string _queryInsert;
        private SqlCommand Cmd { get; set; }
        private SqlConnection Connection { get; set; }
        private readonly User _user;

        public NewUser()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"].ConnectionString;
            _queryInsert = "insert into Users(Name, NickName, Pass) values (@Name, @NickName, @Pass)";

            _user = new User();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            _user.NewName = tbNewName.Text;
            _user.NickName = tbNickName.Text;
            _user.Password = tbNewPassword.Text;

            Insert();
        }

        private void Insert()
        {
            if (tbNewPassword.Text == tbReapPassword.Text)
            {
                try
                {
                    Connection = new SqlConnection(_connectionString);
                    Cmd = new SqlCommand(_queryInsert, Connection);
                    Connection.Open();

                    Cmd.CommandText = "SELECT count(Name) FROM Users WHERE name='" + _user.NewName + "'";
                    var countRows = (int)Cmd.ExecuteScalar();

                    if (countRows == 0)
                    {
                        Cmd.CommandText = _queryInsert;
                        Cmd.Parameters.AddWithValue("@Name", _user.NewName);
                        Cmd.Parameters.AddWithValue("@NickName", _user.NickName);
                        Cmd.Parameters.AddWithValue("@Pass", _user.Password);
                        Cmd.ExecuteNonQuery();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(@"User is already in database!");
                    }
                }
                finally
                {
                    Connection?.Close();
                }
            }
            else
            {
                MessageBox.Show(@"Check your password!");
            }
        }
    }
}

    
