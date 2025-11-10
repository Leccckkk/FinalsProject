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
            StudentCount();
            PassingRate();
            Passed();
            Failed();
            StudentsNotTaken();
        }
        private void StudentsNotTaken()
        {
            int notTakenExamCount = UserManager.NotTakenExam();
            txtnotyet.Text = notTakenExamCount.ToString();
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
            txtpassrate.Text = $"{passingRate:F2}%";
        }
        private void StudentCount()
        {
            int takenExamCount = UserManager.CountStudentsTakenExam();
            txtexams.Text = takenExamCount.ToString();
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

        private void txtstudents_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
