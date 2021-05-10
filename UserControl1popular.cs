using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppprodzekt
{
    public partial class UserControl1popular : UserControl
    {
        public UserControl1popular()
        {
            InitializeComponent();
        }

        private void bttnplus1_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber1.Text) + 1;
            txtBoxNumber1.Text = Convert.ToString(j);
        }

        private void bttnplus2_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber2.Text) + 1;
            txtBoxNumber2.Text = Convert.ToString(j);
        }

        private void bttnplus3_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber3.Text) + 1;
            txtBoxNumber3.Text = Convert.ToString(j);
        }

        private void bttnplus4_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber4.Text) + 1;
            txtBoxNumber4.Text = Convert.ToString(j);
        }

        private void bttnplus5_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber5.Text) + 1;
            txtBoxNumber5.Text = Convert.ToString(j);
        }

        private void bttnplus6_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(txtBoxNumber6.Text) + 1;
            txtBoxNumber6.Text = Convert.ToString(j);
        }
        private void bttnminus1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber1.Text) - 1;
            txtBoxNumber1.Text = Convert.ToString(i);
        }

        private void bttnminus2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber2.Text) - 1;
            txtBoxNumber2.Text = Convert.ToString(i);
        }

        private void bttnminus3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber3.Text) - 1;
            txtBoxNumber3.Text = Convert.ToString(i);
        }

        private void bttnminus4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber4.Text) - 1;
            txtBoxNumber4.Text = Convert.ToString(i);
        }

        private void bttnminus5_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber5.Text) - 1;
            txtBoxNumber5.Text = Convert.ToString(i);
        }

        private void bttnminus6_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtBoxNumber6.Text) - 1;
            txtBoxNumber6.Text = Convert.ToString(i);
        }
    }
}
