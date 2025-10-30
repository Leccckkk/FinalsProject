using FinalsProject.UserControls;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
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


        private void btn_usermanagement_Click(object sender, EventArgs e)
        {
            LoadUserControl (new UserManagement());
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Dashboard());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }

        private void btn_questionmanagement_Click(object sender, EventArgs e)
        {
            LoadUserControl (new QuestionManagement());
        }

        private void btn_studentmanagement_Click(object sender, EventArgs e)
        {
            LoadUserControl (new StudentManagement());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            LoadUserControl (new Reports());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Dashboard());
        }
    }
}
