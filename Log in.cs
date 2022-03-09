using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public partial class Log_in : Form
    {
        public string login;
        public string password;
        Register reg_form;
        Form1 form1;
        User user = null;
        public Log_in()
        {
            InitializeComponent();
        }
        public Log_in(Register _reg_form, Form1 _form1)
        {
            InitializeComponent();
            reg_form = _reg_form;
            form1 = _form1;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void login_box_Leave(object sender, EventArgs e)
        {
            login = login_box.Text;
        }

        private void password_box_Leave(object sender, EventArgs e)
        {
            password = password_box.Text;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if ((login != null) && (password != null))
            {
                byte[] bytes = null;
                try
                {
                    bytes = File.ReadAllBytes(@"Users.bin");
                }
                catch(Exception)
                {
                    MessageBox.Show("Файл с данными о пользователях был повреждён перемещён или удалён. Вы не можете войти", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                string lines = System.Text.Encoding.UTF8.GetString(bytes);
                foreach (string line in lines.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string written_login = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[0];
                    string written_password = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    if (written_login.Equals(login) || written_password.Equals(password))
                    {
                        user = new User(login, password, line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[2], 
                            line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[3], line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[4]);
                        Globals.user = user;
                        Globals.products = user.products;
                        this.Close();
                        reg_form.success = true;
                        reg_form.Hide();
                        Form1 form = new Form1(reg_form);
                        form.Show();
                        break;
                    }
                }
                if(user == null)
                    MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Не все поля заполнены. Заполните", "Ошибка", MessageBoxButtons.OK);
        }

        private void Log_in_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void login_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == ';')
            {
                MessageBox.Show("Символ ; нельзя использовать при регистрации", "Сообщение", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void Show_password_CheckedChanged(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !Show_password.Checked;
        }
    }
}
