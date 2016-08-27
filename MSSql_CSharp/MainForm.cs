using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class MainForm : Form
    {
        Authorisation auth = new Authorisation();

        public MainForm()
        {
            InitializeComponent();
            auth.ShowDialog();
        }
    }
}
