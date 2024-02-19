using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ind_1_9
{
    public partial class User_informations : Form
    {
        private string output = "";
        private KeyValuePair<string, string> pair = new KeyValuePair<string, string>();

        //Получили из начального окна
        private string username;
        private string password;
        private Dictionary<string, string> Users;


        private Dictionary<string, KeyValuePair<string, string>> Info = new Dictionary<string, KeyValuePair<string, string>>();


        public User_informations(string user, string password, Dictionary<string, string> users)
        {
            InitializeComponent();
            this.username = user;
            this.password = password;
            this.Users = users;

            Loading_data();
            Check_user();



            label1.Text = "Information on " + username;
            name_textBox.Text = username;
            last_name_textBox.Text = Info[username].Key;
            email_textBox.Text = Info[username].Value;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            foreach (string i in Info.Keys)
            {
                output += i + ":" + Info[i].Key + ":" + Info[i].Value + "\n";
            }
            System.IO.File.WriteAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Info_about_users.txt", output);
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            foreach (string i in Info.Keys)
            {
                output += i + ":" + Info[i].Key + ":" + Info[i].Value + "\n";
            }
            System.IO.File.WriteAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Info_about_users.txt", output);
            Application.Exit();
        }

        //<-Edit
        private void last_name_button_Click(object sender, EventArgs e)
        {
            Info[name_textBox.Text] = new KeyValuePair<string, string>(last_name_textBox.Text, Info[name_textBox.Text].Value);

        }

        private void email_button_Click(object sender, EventArgs e)
        {
            Info[name_textBox.Text] = new KeyValuePair<string, string>(Info[name_textBox.Text].Key, email_textBox.Text);
        }

        private void name_button_Click(object sender, EventArgs e)
        {
            //Изменение в info_about_user
            Info.Add(name_textBox.Text, Info[username]);
            Info.Remove(username);
            //Изменение в Users_

            Users.Add(name_textBox.Text, password);
            Users.Remove(username);

                 //Сохранение файла Users_
            string ans = "";
            foreach (string i in Users.Keys)
            {
                ans += i + ":" + Users[i] + "\n";
            }
            System.IO.File.WriteAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Users_.txt", ans);
        }


        //Подгрузка файлов и проверка пользователя
        public void Loading_data()
        {
            //Ссылка на файл с данными
            foreach (string i in System.IO.File.ReadAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Info_about_users.txt").Split("\n"))
            {
                if (i.Length > 0)
                {
                    string[] a = i.Split(":");
                    pair = KeyValuePair.Create(a[1], a[2]);
                    Info.Add(key: a[0], pair);
                }
            }

        }

        public void Check_user()
        {
            if (Info.Keys.Contains(username) == false)
            {
                Info.Add(username, pair = KeyValuePair.Create(" ", " "));
            }
            else
            {
                return;
            }
        }

       
    }
}
