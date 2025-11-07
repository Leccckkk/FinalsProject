using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject.UserControls
{
    public partial class Reports : UserControl
    {   
        DataTable dt;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            Passed();
            Failed();
            PassingRate();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dt = UserManager.LoadStudents2();
            dataGridView1.DataSource = dt;
        }
        private void Passed()
        {
            double passing = UserManager.Passed();
            txtpassed.Text = $"{passing}";
        }
        private void Failed()
        {
            double failed = UserManager.Failed();
            txtfailed.Text = $"{failed}";
        }
        private void PassingRate()
        {
            double passingRate = UserManager.Passing();
            txtave.Text = $"{passingRate:F2}%";
        }


    }
}
