using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsProject.StudentControls
{
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "PASSED")
            {
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.ForeColor = Color.Red;
            }
        }
    }
}
