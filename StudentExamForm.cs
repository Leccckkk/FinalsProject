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

namespace FinalsProject
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        int Number = 1, Score = 0;
        string Subject = GlobalDataa.Subject;



        private void ExamForm_Load(object sender, EventArgs e)
        {


            {
                
                {
                    txt_Number.Text = Convert.ToString(Number) + ".";

                    string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
                    MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
                    MySqlCommand sqlcmd = new MySqlCommand();
                    MySqlDataReader sqlreader;

                    sqlconnection.Open();

                    sqlcmd.CommandText = $"SELECT * FROM tbl_questions WHERE number = '{Number}' AND subject = '{Subject}'";
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.Connection = sqlconnection;

                    sqlreader = sqlcmd.ExecuteReader();

                    while (sqlreader.Read())
                    {
                        txt_Question.Text = sqlreader[2].ToString();
                        rb_Choice1.Text = sqlreader[3].ToString();
                        rb_Choice2.Text = sqlreader[4].ToString();
                        rb_Choice3.Text = sqlreader[5].ToString();
                        rb_Choice4.Text = sqlreader[6].ToString();
                    }

                    sqlconnection.Close();

                    Number++;
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (Number <= 10)
            {
                txt_Number.Text = Convert.ToString(Number) + ".";

                string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
                MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
                MySqlCommand sqlcmd = new MySqlCommand();
                MySqlDataReader sqlreader;

                sqlconnection.Open();

                sqlcmd.CommandText = $"SELECT * FROM tbl_questions WHERE number = '{Number}' AND subject = '{Subject}'";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlconnection;

                sqlreader = sqlcmd.ExecuteReader();

                while(sqlreader.Read())
                {
                    txt_Question.Text = sqlreader[2].ToString();
                    rb_Choice1.Text = sqlreader[3].ToString();
                    rb_Choice2.Text = sqlreader[4].ToString();
                    rb_Choice3.Text = sqlreader[5].ToString();
                    rb_Choice4.Text = sqlreader[6].ToString();
                    
                }

                sqlconnection.Close();

                Number++;
            }
            else
            {
                GlobalDataa.Subject = "";
                StudentForm f4 = new StudentForm();
                f4.Show();
                this.Hide();
            }
        }
    }
}
