using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject.StudentControls
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }



        private void Results_Load(object sender, EventArgs e)
        {

            string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
            MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataReader sqlreader;

            sqlconnection.Open();

            sqlcmd.CommandText = $"SELECT * FROM tbl_studentscores WHERE Username = '{GlobalDataa.UserName}'";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconnection;

            sqlreader = sqlcmd.ExecuteReader();

            while (sqlreader.Read())
            {
                if (sqlreader[6].ToString() == "PASSED")
                {
                    Txt_Status.Text = "PASSED";
                    Txt_Status.ForeColor = Color.Green;
                }
                else
                {
                    Txt_Status.Text = "FAILED";
                    Txt_Status.ForeColor = Color.Red;
                }

                Txt_OverScore.Text = Convert.ToString(sqlreader[5].ToString()) + "/100";

                Txt_MathS.Text = Convert.ToString(sqlreader[1].ToString()) + "/25";
                Txt_EngS.Text = Convert.ToString(sqlreader[2].ToString()) + "/25";
                Txt_SciS.Text = Convert.ToString(sqlreader[3].ToString()) + "/25";
                Txt_HisS.Text = Convert.ToString(sqlreader[4].ToString()) + "/25";

                txt_Math.Text = Evaluate.EvaluateSubject(Convert.ToInt32(sqlreader[1].ToString()));
                txt_eng.Text = Evaluate.EvaluateSubject(Convert.ToInt32(sqlreader[2].ToString()));
                txt_sci.Text = Evaluate.EvaluateSubject(Convert.ToInt32(sqlreader[3].ToString()));
                txt_his.Text = Evaluate.EvaluateSubject(Convert.ToInt32(sqlreader[4].ToString()));


            }

            sqlconnection.Close();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
