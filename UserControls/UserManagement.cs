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

            string Username = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();
            string userType = dataGridView1.CurrentRow.Cells["userType"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete the user '{Username}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (userType.ToLower() == "admin")
            {
                MessageBox.Show("Admin accounts cannot be deleted.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (confirm == DialogResult.No)
                return;

            try
            {
                UserManager.DeleteUser(Username); 

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {
            dt = UserManager.LoadUsers2(tb_User.Text);
            dataGridView1.DataSource = dt;
        }

    }
}
