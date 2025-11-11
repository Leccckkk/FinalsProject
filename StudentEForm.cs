using FinalsProject.StudentControls;
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

namespace FinalsProject
{
    public partial class StudentEForm : Form
    {
        public StudentEForm()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }
        public void Disable()
        {
            btn_takeexam.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StudentControls.ExamForm());
        }

        private void StudentEForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new StudentControls.ExamForm());
            CheckExamStatus();

        }
        private void CheckExamStatus()
        {
            string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
            using (MySqlConnection sqlconnection = new MySqlConnection(dbconnect))
            {
                sqlconnection.Open();
                string query = "SELECT COUNT(*) FROM tbl_studentscores WHERE Username = @user";
                MySqlCommand sqlcmd = new MySqlCommand(query, sqlconnection);
                sqlcmd.Parameters.AddWithValue("@user", GlobalDataa.UserName);

                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count > 0)
                {
                    btn_takeexam.Visible = false;
                    txt_EnrollmentStatus.Text = "EXAM ALREADY TAKEN";
                    return;
                }

                string queryEnroll = "SELECT EnrollmentStatus FROM tbl_users WHERE Username = @user";
                MySqlCommand enrollCmd = new MySqlCommand(queryEnroll, sqlconnection);
                enrollCmd.Parameters.AddWithValue("@user", GlobalDataa.UserName);

                object result = enrollCmd.ExecuteScalar();

                if (result != null)
                {
                    string status = result.ToString();

                    if (status == "Enrolled")
                    {
                        btn_takeexam.Visible = true;
                        txt_EnrollmentStatus.Text = "";

                    }
                    else if (status == "Not Enrolled")
                    {
                        btn_takeexam.Visible = false;
                        txt_EnrollmentStatus.Text = "NOT ENROLLED!!!";
                    }
                }
                else
                {
                    btn_takeexam.Visible = false;
                }
            }

        }
        


        private void btn_results_Click(object sender, EventArgs e)
        {

            ExamForm f1 = new ExamForm(this);
            f1.Show();
            this.Hide();
        }

        private void btn_viewresults_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StudentControls.Results());
        }
    }
}
