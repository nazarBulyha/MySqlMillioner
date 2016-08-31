using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class MainForm : Form
    {
        private Authorisation Auth { get; }

        public MainForm()
        {
            InitializeComponent();
            Auth = new Authorisation();
            Auth.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Auth.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
