using System;
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
            Hide();
            Auth.ShowDialog();
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDbDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.logDbDataSet.Users);
        }

        private void btnPhys_Click(object sender, System.EventArgs e)
        {
            HideButtons();
        }

        private void btnMath_Click(object sender, System.EventArgs e)
        {
            HideButtons();
        }

        private void btnProg_Click(object sender, System.EventArgs e)
        {
            HideButtons();
        }

        private void HideButtons()
        {
            gbChoose.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbChoose.Visible = true;
        }
    }
}
