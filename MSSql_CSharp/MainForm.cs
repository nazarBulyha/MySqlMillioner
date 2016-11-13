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
        private List<string> correctAnswers;
        public static int I { get; set; } = 0;

        private readonly string _connectionString;
        private readonly string _querySelect;
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
            gbQA.Visible = false;
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
            var qAnswers = new QuestionAnswers();
            GetListQuestions(qAnswers);
            ShuffleListQuestions(qAnswers);


            lblQuestionNumber.Text = @"Question: " + (I + 1);

            foreach (var qa in qAnswers.QA)
            {
                CorectAnswer = correctAnswers[I];
                lblQuestion.Text = qAnswers.QA[I].Question;
                btnA.Text = qAnswers.QA[I].GoodAnswer;
                btnB.Text = qAnswers.QA[I].Answer2;
                btnC.Text = qAnswers.QA[I].Answer3;
                btnD.Text = qAnswers.QA[I].Answer4;
            }
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
            {
                I++;
                OrderQuestions();
            }
            else
                LoseForn();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == CorectAnswer)
            {
                I++;
                OrderQuestions();
            }
            else
                LoseForn();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == CorectAnswer)
            {
                I++;
                OrderQuestions();
            }
            else
                LoseForn();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == CorectAnswer)
            {
                I++;
                OrderQuestions();
            }
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

        private void GetListQuestions(QuestionAnswers qAnswer)
        {
            try
            {
                Connection = new SqlConnection(_connectionString);
                Cmd = new SqlCommand(_querySelect, Connection);
                Connection.Open();

                using (var sqlReader = Cmd.ExecuteReader()) //Get data from sqlTable and write it to qAnswer class
                {
                    while (sqlReader.Read())
                    {
                        qAnswer = new QuestionAnswers()
                        {
                            Question = (string)sqlReader[1],
                            GoodAnswer = (string)sqlReader[2],
                            Answer2 = (string)sqlReader[3],
                            Answer3 = (string)sqlReader[4],
                            Answer4 = (string)sqlReader[5],
                        };
                        qAnswer.addQA(qAnswer);
                    }
                }
            }
            finally
            {
                Connection?.Close();
            }
        }

        private QuestionAnswers ShuffleListQuestions(QuestionAnswers qAnswer)
        {
            foreach (var qA in qAnswer.QA)
            {
                var qaList = new List<string> { qA.GoodAnswer, qA.Answer2, qA.Answer3, qA.Answer4 };
                correctAnswers.Add(qA.GoodAnswer);
                qaList.OrderBy(x => _rnd.Next()).ToList();
                qAnswer.GoodAnswer = qaList[0];
                qAnswer.Answer2 = qaList[1];
                qAnswer.Answer3 = qaList[2];
                qAnswer.Answer4 = qaList[3];
            }
            return qAnswer;
        }
    }
}