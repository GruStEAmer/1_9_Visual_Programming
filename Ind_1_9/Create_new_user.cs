using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ind_1_9
{
    public partial class Create_new_user : Form
    {
        Dictionary<string, string> Users;

        public Create_new_user(Dictionary<string, string> users)
        {
            InitializeComponent();
            this.Users = users;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(Object sender, EventArgs e)
        {



            if (user_textBox.Text.Length > 0 && password_textBox.Text.Length > 0 && Confirm_password_textBox.Text == password_textBox.Text)
            {
                if (!Users.Keys.Contains(user_textBox.Text))
                {
                    Users.Add(user_textBox.Text, password_textBox.Text);
                }
                else
                {
                    user_textBox.Text = "Такой пользователь уже есть";
                    return;
                }
            }
            else
            {
                user_textBox.Text = "Введите корректно данные";
                return;
            }
            string ans = "";
            foreach (string i in Users.Keys)
            {
                ans += i + ":" + Users[i] + "\n";
            }

            //Здесь указывать путь к своему тексовому файлу
            System.IO.File.WriteAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Users_.txt", ans);

            this.Close();
        }


        //Очистка экрана, перед новым вводом
        private void user_textBox_Click(object sender, EventArgs e)
        {
            user_textBox.Text = "";
        }
        //Скрытие или показ пароля
        private void password_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_checkBox.Checked)
            {
                password_textBox.UseSystemPasswordChar = false;
                Confirm_password_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                password_textBox.UseSystemPasswordChar = true;
                Confirm_password_textBox.UseSystemPasswordChar = true;
            }
        }

       
    }
}
