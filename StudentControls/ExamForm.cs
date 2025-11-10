using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject.StudentControls
{
    public partial class ExamForm : UserControl
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        private void btn_takeexam_Click(object sender, EventArgs e)
        {
            
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
            MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataReader sqlreader;

            sqlconnection.Open();
            sqlcmd.CommandText = $"SELECT name FROM tbl_users WHERE Username = '{GlobalDataa.UserName}'";
            sqlcmd.Connection = sqlconnection;
            sqlreader = sqlcmd.ExecuteReader();

            if (sqlreader.Read())
            {
                txt_StudName.Text = sqlreader["name"].ToString();
            }
            sqlreader.Close();

            sqlcmd.CommandText = $"SELECT * FROM tbl_studentscores WHERE Username = '{GlobalDataa.UserName}'";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconnection;

            sqlreader = sqlcmd.ExecuteReader();

            while (sqlreader.Read())
            {
                if (sqlreader[6].ToString() == "PASSED")
                {
                    txtstats.Text = "PASSED";
                    txtstats.ForeColor = Color.Green;
                    txtaverage.Text = Convert.ToDouble(sqlreader[9]).ToString("F2") + "%";
                    txtaverage.ForeColor = Color.Green;
                }
                else
                {
                    txtstats.Text = "FAILED";
                    txtstats.ForeColor = Color.Red;
                    txtaverage.Text = Convert.ToDouble(sqlreader[9]).ToString("F2") + "%";
                    txtaverage.ForeColor = Color.Red;
                }


            }

            sqlconnection.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
