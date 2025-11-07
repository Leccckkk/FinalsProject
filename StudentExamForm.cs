using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalsProject
{
    public partial class ExamForm : Form
    {
        private StudentEForm _studentEForm;
        public ExamForm(StudentEForm studentForm)
        {
            InitializeComponent();
            _studentEForm = studentForm;


        }

        int Number = 1, Score = 0, Sum = 0;
        string Subject = "Mathematics";
        string CorrectAnswer = "";
        int SubjectPoints = 0;
        int CurrentPoints = 0;

        private void ExamForm_Load(object sender, EventArgs e)
        {
            txt_subject.Text = Subject;
            txt_Number.Text = Convert.ToString(Number) + ".";
            LoadQuestion();
        }
        private void LoadQuestion()
        {
            string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
            using (MySqlConnection sqlconnection = new MySqlConnection(dbconnect))
            {
                sqlconnection.Open();
                string query = $"SELECT * FROM tbl_questions WHERE subject = '{Subject}' ORDER BY RAND() LIMIT 1";
                MySqlCommand sqlcmd = new MySqlCommand(query, sqlconnection);
                MySqlDataReader sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    txt_subject.Text = sqlreader["subject"].ToString();
                    txt_Question.Text = sqlreader["question"].ToString();
                    rb_Choice1.Text = sqlreader["choiceA"].ToString();
                    rb_Choice2.Text = sqlreader["choiceB"].ToString();
                    rb_Choice3.Text = sqlreader["choiceC"].ToString();
                    rb_Choice4.Text = sqlreader["choiceD"].ToString();
                    CorrectAnswer = sqlreader["answer"].ToString();
                    CurrentPoints = Convert.ToInt32(sqlreader["points"]);
                    txt_point.Text = $"{CurrentPoints} point{(CurrentPoints > 1 ? "s" : "")}";
                }
            }
        }



        private void btn_Next_Click_1(object sender, EventArgs e)
        {

            if (rb_Choice1.Checked && rb_Choice1.Text == CorrectAnswer)
            {
                Score += CurrentPoints;
                SubjectPoints += CurrentPoints;
            }
            else if (rb_Choice2.Checked && rb_Choice2.Text == CorrectAnswer)
            {
                Score += CurrentPoints;
                SubjectPoints += CurrentPoints;
            }
            else if (rb_Choice3.Checked && rb_Choice3.Text == CorrectAnswer)
            {
                Score += CurrentPoints;
                SubjectPoints += CurrentPoints;
            }
            else if (rb_Choice4.Checked && rb_Choice4.Text == CorrectAnswer)
            {
                Score += CurrentPoints;
                SubjectPoints += CurrentPoints;
            }

            if ((Number == 11) || SubjectPoints >= 25)
            {
                GlobalDataa.MathScore = Score;
                Sum += Score;
                Score = 0;
                SubjectPoints = 0;
                Subject = "English";
            }
            else if ((Number == 21) || SubjectPoints >= 25)
            {
                GlobalDataa.EnglishScore = Score;
                Sum += Score;
                Score = 0;
                SubjectPoints = 0;
                Subject = "Science";
            }
            else if ((Number == 31) || SubjectPoints >= 25)
            {
                GlobalDataa.ScienceScore = Score;
                Sum += Score;
                Score = 0;
                SubjectPoints = 0;
                Subject = "History";
            }

            if (Number > 40 || SubjectPoints >= 25)
            {
                GlobalDataa.HistoryScore = Score;
                Sum += Score;

                string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
                using (MySqlConnection sqlconnection = new MySqlConnection(dbconnect))
                {
                    sqlconnection.Open();
                    string query = "INSERT INTO tbl_studentscores " +
                                   "(Username, MathScore, EngScore, SciScore, HisScore, SumScore) " +
                                   "VALUES (@user, @math, @eng, @sci, @his, @sum)";
                    MySqlCommand sqlcmd = new MySqlCommand(query, sqlconnection);
                    sqlcmd.Parameters.AddWithValue("@user", GlobalDataa.UserName);
                    sqlcmd.Parameters.AddWithValue("@math", GlobalDataa.MathScore);
                    sqlcmd.Parameters.AddWithValue("@eng", GlobalDataa.EnglishScore);
                    sqlcmd.Parameters.AddWithValue("@sci", GlobalDataa.ScienceScore);
                    sqlcmd.Parameters.AddWithValue("@his", GlobalDataa.HistoryScore);
                    sqlcmd.Parameters.AddWithValue("@sum", Sum);
                    sqlcmd.ExecuteNonQuery();
                }

                GlobalDataa.StudentScore = Sum;
                MessageBox.Show("Exam Finished!");
                _studentEForm.Disable();
                _studentEForm.Show();
                this.Close();
                return;
            }

            if (Number == 40)
                btn_Next.Text = "Finish";

            if (Number <= 40)
            {
                txt_subject.Text = Subject;
                txt_Number.Text = Convert.ToString(Number) + ".";
                LoadQuestion();
                Number++;
            }
        }
    }
}
