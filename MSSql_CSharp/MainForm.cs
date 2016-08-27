using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class MainForm : Form
    {
        Authorisation auth;
        public MainForm()
        {
            InitializeComponent();
            auth = new Authorisation();
            auth.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            auth.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
