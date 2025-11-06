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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string LoginReturn = Login.CheckLogin(tb_Username.Text, tb_Password.Text);
            if (LoginReturn == "admin")
            {
                GlobalDataa.UserName = tb_Username.Text;
                AdminForm f2 = new AdminForm();
                f2.Show();
                this.Hide();
            }
            else if (LoginReturn == "faculty")
            {
                GlobalDataa.UserName = tb_Username.Text;
                FacultyForm f3 = new FacultyForm();
                f3.Show();
                this.Hide();
            }
            else if (LoginReturn == "student")
            {
                GlobalDataa.UserName = tb_Username.Text;
                StudentEForm f4 = new StudentEForm();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
