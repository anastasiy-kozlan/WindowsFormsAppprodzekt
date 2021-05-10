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
    public partial class FormForСlient : Form
    {
        public FormForСlient()
        {
            InitializeComponent();
        }

        private void FormForСlient_Load(object sender, EventArgs e)
        {
            
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void bttnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
