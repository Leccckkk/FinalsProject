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
    public partial class QuestionManagement : UserControl
    {
        DataTable dt;
        public QuestionManagement()
        {
            InitializeComponent();
        }
        
        private void QuestionManagement_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadSubjectCounts();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            dataGridView1.UserDeletedRow += dataGridView1_UserDeletedRow;
        }
        private void LoadGrid()
        {
            dt = QuestionManager.LoadQuestions();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].ReadOnly = true;
        }
        private void LoadSubjectCounts()
        {
            txtmath.Text = QuestionManager.CountQuestionsBySubject("Mathematics").ToString();
            txteng.Text = QuestionManager.CountQuestionsBySubject("English").ToString();
            txtsci.Text = QuestionManager.CountQuestionsBySubject("Science").ToString();
            txthis.Text = QuestionManager.CountQuestionsBySubject("History").ToString();
        }
        private void LoadSubjectCountsLocal()
        {
            if (dt == null) return;

            txtmath.Text = dt.Select("subject = 'Mathematics'").Length.ToString();
            txteng.Text = dt.Select("subject = 'English'").Length.ToString();
            txtsci.Text = dt.Select("subject = 'Science'").Length.ToString();
            txthis.Text = dt.Select("subject = 'History'").Length.ToString();
        }
        private void LoadSubjectCountsDatabase()
        {
            txtmath.Text = QuestionManager.CountQuestionsBySubject("Mathematics").ToString();
            txteng.Text = QuestionManager.CountQuestionsBySubject("English").ToString();
            txtsci.Text = QuestionManager.CountQuestionsBySubject("Science").ToString();
            txthis.Text = QuestionManager.CountQuestionsBySubject("History").ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            QuestionManager.SaveChanges(dt);
            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
            LoadSubjectCountsDatabase();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            LoadSubjectCountsLocal();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            LoadSubjectCountsLocal();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            LoadSubjectCountsLocal();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this question?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            QuestionManager.DeleteQuestion(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            LoadSubjectCountsLocal();
            LoadSubjectCountsDatabase();

            MessageBox.Show("Question deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
