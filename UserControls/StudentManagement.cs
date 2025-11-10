using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalsProject.UserControls
{
    public partial class StudentManagement : UserControl
    {
        DataTable dt;
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            dt = UserManager.LoadStudents(tb_User.Text);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            
            LoadGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            UserManager.SaveStudentScores(dt);
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

            string Username = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete the record of user'{Username}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
                return;

            try
            {
                UserManager.DeleteRecord(Username);

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            dt = UserManager.LoadStudents(tb_User.Text);
            dataGridView1.DataSource = dt;
        }
    }
    }

