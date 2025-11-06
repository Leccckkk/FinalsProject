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
    public partial class Dashboard : UserControl
    {
        DataTable dt;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCountingStudents();
            LoadSubjectCounts();
        }
        private void LoadUsers()
        {
            dt = UserManager.LoadUsers();
            dt = QuestionManager.LoadQuestions();
        }
        private void LoadCountingStudents()
        {
            txtstudents.Text = UserManager.CountStudents("student").ToString();
        }
        private void LoadSubjectCounts()
        {
            txtquestions.Text = (QuestionManager.CountQuestionsBySubject("Mathematics")
                + QuestionManager.CountQuestionsBySubject("English")
                + QuestionManager.CountQuestionsBySubject("Science")
                + QuestionManager.CountQuestionsBySubject("History")).ToString();
        }
    }
}
