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
    public partial class UserManagement : UserControl
    {
        DataTable dt;
        public UserManagement()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dt = UserManager.LoadUsers();
            dataGridView1.DataSource = dt;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            UserManager.SaveChanges(dt);
            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Username = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Username"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this question?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            QuestionManager.DeleteQuestion(Username);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


            MessageBox.Show("Question deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
