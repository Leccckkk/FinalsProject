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
        string Subject = "Mathematics", Status = "";





        private void ExamForm_Load(object sender, EventArgs e)
        {


            {

                {
                    
                    txt_subject.Text = Subject;
                    txt_Number.Text = Convert.ToString(Number) + ".";
                    Random rnd = new Random();
                    int number = rnd.Next(1, 126);
                    GlobalDataa.RandomNumber = number;

                    string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
                    MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
                    MySqlCommand sqlcmd = new MySqlCommand();
                    MySqlDataReader sqlreader;

                    sqlconnection.Open();

                    sqlcmd.CommandText = $"SELECT * FROM tbl_questions WHERE subject = '{Subject}' ORDER BY RAND() LIMIT 1";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlconnection;

                    sqlreader = sqlcmd.ExecuteReader();

                    while (sqlreader.Read())
                    {
                        txt_subject.Text = sqlreader[2].ToString();
                        txt_Question.Text = sqlreader[3].ToString();
                        rb_Choice1.Text = sqlreader[4].ToString();
                        rb_Choice2.Text = sqlreader[5].ToString();
                        rb_Choice3.Text = sqlreader[6].ToString();
                        rb_Choice4.Text = sqlreader[7].ToString();
                    }

                    sqlconnection.Close();

                    Number++;
                }
            }
        }




        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            int number = GlobalDataa.RandomNumber;

            if (Number == 11)
            {
                GlobalDataa.MathScore = Score;
                Sum += Score;
                Score = 0;
                Subject = "English";
            }
            if (Number == 21)
            {
                GlobalDataa.EnglishScore = Score;
                Sum += Score;
                Score = 0;
                Subject = "Science";
            }
            if (Number == 31)
            {
                GlobalDataa.ScienceScore = Score;
                Sum += Score;
                Score = 0;
                Subject = "History";
            }

            string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
            MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataReader sqlreader;

            sqlconnection.Open();

            sqlcmd.CommandText = $"SELECT * FROM tbl_questions WHERE subject = '{Subject}' ORDER BY RAND() LIMIT 1";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconnection;

            sqlreader = sqlcmd.ExecuteReader();

            while (sqlreader.Read())
            {
                if (rb_Choice1.Checked == true)
                {
                    if (rb_Choice1.Text == sqlreader[8].ToString())
                    {
                        Score++;
                    }
                }
                else if (rb_Choice2.Checked == true)
                {
                    if (rb_Choice2.Text == sqlreader[8].ToString())
                    {
                        Score++;
                    }
                }
                else if (rb_Choice3.Checked == true)
                {
                    if (rb_Choice3.Text == sqlreader[8].ToString())
                    {
                        Score++;
                    }
                }
                else if (rb_Choice4.Checked == true)
                {
                    if (rb_Choice4.Text == sqlreader[8].ToString())
                    {
                        Score++;
                    }
                }

            }

            sqlconnection.Close();
            if (Number == 40)
            {
                btn_Next.Text = "Finish";
            }
            if (Number <= 40)
            {
                txt_subject.Text = Subject;
                txt_Number.Text = Convert.ToString(Number) + ".";
                Random rnd = new Random();
                number = rnd.Next(1, 126);
                GlobalDataa.RandomNumber = number;



                sqlconnection.Open();

                sqlcmd.CommandText = $"SELECT * FROM tbl_questions WHERE subject = '{Subject}' ORDER BY RAND() LIMIT 1";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlconnection;

                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    txt_subject.Text = sqlreader[2].ToString();
                    txt_Question.Text = sqlreader[3].ToString();
                    rb_Choice1.Text = sqlreader[4].ToString();
                    rb_Choice2.Text = sqlreader[5].ToString();
                    rb_Choice3.Text = sqlreader[6].ToString();
                    rb_Choice4.Text = sqlreader[7].ToString();

                }

                sqlconnection.Close();

                Number++;
            }
            else
            {
                GlobalDataa.HistoryScore = Score;
                Sum += Score;   
                Score = 0;
                if (Sum / 2 >= 20)
                {
                    Status = "PASSED";
                    
                }
                else
                {
                    Status = "FAILED";
                    
                }


                sqlconnection.Open();

                sqlcmd.CommandText = $"INSERT INTO tbl_studentscores (Username, MathScore, EngScore, SciScore, HisScore, SumScore, Status)" +
                                     $"VALUES ('{GlobalDataa.UserName}', {GlobalDataa.MathScore}, {GlobalDataa.EnglishScore}, {GlobalDataa.ScienceScore}, {GlobalDataa.HistoryScore}, {Sum}, '{Status}')";


                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlconnection;

                sqlcmd.ExecuteNonQuery();

                sqlconnection.Close();

                GlobalDataa.StudentScore = Sum;

                MessageBox.Show("Exam Finished!");
                _studentEForm.Disable();
                _studentEForm.Show();
                this.Close();

            }

        } 
    }
}
