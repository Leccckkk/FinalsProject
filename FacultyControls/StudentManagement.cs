using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject.FacultyControls
{
    public partial class StudentManagement : UserControl
    {
        DataTable dt;
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dt = UserManager.LoadStudents(tb_User.Text);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            dt = UserManager.LoadStudents(tb_User.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
