using MySql.Data.MySqlClient;
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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void bttncomein_Click(object sender, EventArgs e)
        {
            // записали в переменную
            String loginUser = textBoxLogin.Text;
            String passnUser = textBoxPassword.Text;
            try
            {
                if (loginUser == "" && passnUser == "")
                    MessageBox.Show("Ви не ввели логін та пароль", "Помилка    001", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                           if (loginUser == "")
                    MessageBox.Show("Ви не ввели логін", "Помилка    002", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                           if (passnUser == "")
                    MessageBox.Show("Ви не ввели пароль", "Помилка    003", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else

               if (loginUser != "" && passnUser != "")
                {
                 //
                   BD db = new BD();

                 // DataTable - послужил для преобразования данных из БД в таблицу что можно разобрать на языке C#
                  DataTable table = new DataTable();

                 // MySqlDataAdapter - служит для перевода из SQL данных в данные обычные (массивы, объекты...)
                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                 // MySqlCommand - позволяет записать SQL команду, что будет выполнена в базе данных
                   MySqlCommand command = new MySqlCommand("select*from `users` where `login` = @ul and `passwords`= @up", db.getConnection());

                  command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
                  command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passnUser;


                  adapter.SelectCommand = command;
                  adapter.Fill(table);

                     if (table.Rows.Count > 0)
                     {
                        if (loginUser == "administrator")
                        {
                            FormForAdministrator form = new FormForAdministrator();
                            form.Show();
                        }
                        else
                        if (loginUser == "bartender")
                        {
                            FormForBartender form = new FormForBartender();
                            form.Show();
                        }
                        else
                        if (loginUser == "monoblock")
                        {
                            FormForMonoblock form = new FormForMonoblock();
                            form.Show();
                        }
                        else
                        {
                            FormForСlient form = new FormForСlient();
                            form.Show();
                        }

                     }
                    else
                    {                 
                        MessageBox.Show("Такого користувача не існує" + "\n" + "Перевірте правильність логіну та пароля \n або зарегеструйтесь(зверніться до адміністратора)", "Помилка    004", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Помилка підключення", "Помилка    005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
