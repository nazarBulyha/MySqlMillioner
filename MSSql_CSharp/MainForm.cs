using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MSSql_CSharp
{
    public partial class MainForm : Form
    {
        public string CorectAnswer { get; set; }

        private readonly string _connectionString;
        private readonly string _querySelect;
        public static int I { get; set; }
        private Authorisation Auth { get; }
        private SqlCommand Cmd { get; set; }
        private SqlConnection Connection { get; set; }

        private readonly Random _rnd = new Random();

        public MainForm()
        {
            InitializeComponent();

            Auth = new Authorisation();
            Auth.ShowDialog();

            _connectionString = ConfigurationManager.ConnectionStrings["MSSql_CSharp.Properties.Settings.LogDbConnectionString"].ConnectionString;
            _querySelect = "select * from QuestionsAnswers";
        }

        #region Login-Exit-NewGame

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Auth.ShowDialog();
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbChoose.Visible = true;
        }

        #endregion

        #region Buttons QuestionsCategory_Click

        private void btnPhys_Click(object sender, EventArgs e)
        {
            HideButtons();
            OrderQuestions();
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            HideButtons();
            OrderQuestions();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            HideButtons();
            OrderQuestions();
        }

        #endregion

        #region Buttons Manipulation
        private void OrderQuestions()
        {
            do
            {
                var qaAnswers = new QuestionAnswers();
                GetQuestions(qaAnswers);

                var tempListAnswers = new List<string> { qaAnswers.GoodAnswer, qaAnswers.Answer2, qaAnswers.Answer3, qaAnswers.Answer4 };
                var listAnswers = tempListAnswers.OrderBy(x => _rnd.Next()).ToList();

                lblQuestionNumber.Text = @"Question: " + I;
                lblQuestion.Text = qaAnswers.Question;
                CorectAnswer = qaAnswers.GoodAnswer;

                for (var temp = 0; temp < 4; temp++)
                {
                    btnA.Text = listAnswers[temp];
                    btnB.Text = listAnswers[temp];
                    btnC.Text = listAnswers[temp];
                    btnD.Text = listAnswers[temp];
                }


            } while (I <= 10);
        }

        private void HideButtons()
        {
            gbChoose.Visible = false;
            gbQA.Visible = true;
        }

        #endregion

        #region Buttons ABCD_Click

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == CorectAnswer)
                I++;
            else
                LoseForn();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == CorectAnswer)
                I++;
            else
                LoseForn();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == CorectAnswer)
                I++;
            else
                LoseForn();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == CorectAnswer)
                I++;
            else
                LoseForn();
        }

        #endregion

        private void LoseForn()
        {
            gbQA.Visible = false;
            MessageBox.Show(@"Do you want to play again?", @"You lose!", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                gbChoose.Visible = true;
            }
            else
            {
                Close();
            }
        }

        private void GetQuestions(QuestionAnswers qAnswer)
        {
            Connection = new SqlConnection(_connectionString);
            Cmd = new SqlCommand(_querySelect, Connection);
            
            using (var sqlReader = Cmd.ExecuteReader()) //Get data from sqlTable and write it to qAnswer class
            {
                while (sqlReader.Read())
                {
                    qAnswer.Question = (string) sqlReader[0];
                    qAnswer.GoodAnswer = (string) sqlReader[1];
                    qAnswer.Answer2 = (string) sqlReader[2];
                    qAnswer.Answer3 = (string) sqlReader[3];
                    qAnswer.Answer4 = (string) sqlReader[4];
                }
            }
        }
    }
}