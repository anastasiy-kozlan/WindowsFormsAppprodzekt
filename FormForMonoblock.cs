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
    public partial class FormForMonoblock : Form
    {
        public FormForMonoblock()
        {
            this.Size = new Size(2500, 1000);
            InitializeComponent();
        }

        private void FormForMonoblock_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви знаєте що замовити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            if (result == DialogResult.No)
            {
              
            }
            else
                return;
        }


        private void movesidepanel(Button btn)
        {
            panelslid.Top = btn.Top;
            panelslid.Height = btn.Height;
        }
        private void addUS(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void textBoxOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void popular_Click_1(object sender, EventArgs e)
        {
            movesidepanel(popular);
        }

        private void wine_Click_1(object sender, EventArgs e)
        {
            movesidepanel(wine);
        }

        private void beer_Click_1(object sender, EventArgs e)
        {
            movesidepanel(beer);
        }

        private void strong_Click_1(object sender, EventArgs e)
        {
            movesidepanel(strong);
        }

        private void water_Click_1(object sender, EventArgs e)
        {
            movesidepanel(water);
        }

        private void Acocktail_Click_1(object sender, EventArgs e)
        {
            movesidepanel(Acocktail);
            UserControl1popular UCPopular = new UserControl1popular();
            addUS(UCPopular);
        }

        private void Bcocktail_Click_1(object sender, EventArgs e)
        {
            movesidepanel(Bcocktail);
        }

        private void non_Click_1(object sender, EventArgs e)
        {
            movesidepanel(non);
        }

        private void snacks_Click_1(object sender, EventArgs e)
        {
            movesidepanel(snacks);
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void bttnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
