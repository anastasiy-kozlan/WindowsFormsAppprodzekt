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
    public partial class FormForAdministrator : Form
    {
        public FormForAdministrator()
        {
            InitializeComponent();
        }

        private void FormForAdministrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersdbDataSet2.menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.usersdbDataSet2.menu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersdbDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersdbDataSet.users);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView1.EndEdit();
            this.usersTableAdapter.Fill(this.usersdbDataSet.users);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView1.EndEdit();
            this.menuTableAdapter.Fill(this.usersdbDataSet2.menu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
