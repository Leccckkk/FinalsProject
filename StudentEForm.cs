using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalsProject.StudentControls;

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
