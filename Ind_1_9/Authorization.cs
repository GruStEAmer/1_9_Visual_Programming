using Microsoft.VisualBasic.ApplicationServices;

namespace Ind_1_9
{
    public partial class Authorization : Form
    {

        private Dictionary<string, string> Users = new Dictionary<string, string>();

        public Authorization()
        {
            InitializeComponent();
            Loading_data();
        }

        //Команды действий
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_button_Click(Object sender, EventArgs e)
        {
            if (Users.ContainsKey(user_text.Text))
            {
                if (Users[user_text.Text] == password_text.Text)
                {

                    Form user_inf = new User_informations(user_text.Text, password_text.Text, Users);
                    user_inf.ShowDialog();
                }
                else
                {
                    user_text.Text = "Ошибка:Пароль";
                    password_text.Clear();
                }
;
            }
            else
            {
                user_text.Text = "Ошибка:Пользователь";
            }
        }

        private void create_user_button_Click(object sender, EventArgs e)
        {
            Form f = new Create_new_user(Users);
            f.ShowDialog(this);

        }



        //Если клик на user_Text_Box 
        private void user_text_Click(object sender, EventArgs e)
        {
            user_text.Text = "";
        }

        //Прогружаем все данные
        public void Loading_data()
        {
            //Ссылка на файл с данными
            foreach (string i in System.IO.File.ReadAllText("D:\\VisualProgrammingProjects\\Ind_1_9\\Ind_1_9\\txtfiles\\Users_.txt").Split("\n"))
            {
                if (i.Length > 0)
                {
                    string[] a = i.Split(":");
                    Users.Add(a[0], a[1]);
                }
            }
        }

        
    }
}
