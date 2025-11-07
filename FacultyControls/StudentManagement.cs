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
            dt = UserManager.LoadStudents();
            dataGridView1.DataSource = dt;
        }
    }
}
