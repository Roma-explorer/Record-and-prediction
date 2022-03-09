using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public partial class Register : Form
    {
        public string login = null;
        public string password = null;
        public string org_name = null;
        public string org_file_path = null;
        public string data_file_path = null;
        public bool success = false;
        Form1 form1;
        public Register()
        {
            InitializeComponent();
        }
        private void login_box_Leave(object sender, EventArgs e)
        {
            login = login_box.Text;
        }

        private void password_box_Leave(object sender, EventArgs e)
        {
            password = password_box.Text;
        }

        private void org_name_box_Leave(object sender, EventArgs e)
        {
            org_name = org_name_box.Text;
        }

        private void choose_org_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Выберите файл";
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        org_file_path = openFileDialog1.FileName;
                        choose_org_file.Text = openFileDialog1.FileName.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();
                    }
                    catch (Exception)
                    {
                        choose_org_file.Text = "Sorry, something went wrong. Let's try again";
                    }
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if((login!=null)&&(password!=null)&&(org_name!=null) && (org_file_path != null) && (data_file_path != null))
            {
                var file = new FileInfo(@"Users.bin");
                if (file.Exists == false || file.Length == 0)
                {
                    string line = string.Concat(login, ';', password, ';', org_name, ';', org_file_path, ';', data_file_path, '\n');
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(line);
                    FileStream bin = new FileStream(@"Users.bin", FileMode.Create, FileAccess.Write);
                    bin.Write(bytes, 0, bytes.Length);
                    bin.Close();
                }
                else
                {
                    byte[] bytes = File.ReadAllBytes(@"Users.bin");
                    string lines = System.Text.Encoding.UTF8.GetString(bytes);
                    foreach (string line in lines.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        string written_login = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[0];
                        string written_password = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)[1];
                        if (written_login.Equals(login) || written_password.Equals(password))
                        {
                            MessageBox.Show("Логин или пароль совпал с уже существующим. Придумайте другой.", "Совпадение", MessageBoxButtons.OK);
                            break;
                        }
                    }
                    string new_line = string.Concat(login, ';', password, ';', org_name, ';', org_file_path, ';', data_file_path, '\n');
                    lines = string.Concat(lines, new_line);
                    File.WriteAllText(@"Users.txt", new_line);
                    File.WriteAllBytes(@"Users.bin", System.Text.Encoding.UTF8.GetBytes(lines));
                    User user = new User(login, password, org_name, org_file_path, data_file_path);
                    Globals.user = user;
                    Globals.products = user.products;
                    success = true;
                    Form1 form = new Form1(this);
                    form.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Не все поля заполнены. Заполните", "Ошибка", MessageBoxButtons.OK);
        }

        private void org_name_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == ';')
            {
                MessageBox.Show("Символ ; нельзя использовать при регистрации", "Сообщение", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            var file = new FileInfo(@"Users.bin");
            if (file.Exists == false || file.Length == 0)
            {
                MessageBox.Show("Никаких зарегестрированных пользователей нет. Пройдите регистрацию.", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                Log_in log_form = new Log_in(this, form1);
                log_form.Show();
            }
        }

        private void choose_data_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Выберите файл";
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        data_file_path = openFileDialog1.FileName;
                        choose_data_file.Text = openFileDialog1.FileName.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();
                    }
                    catch (Exception)
                    {
                        choose_org_file.Text = "Sorry, something went wrong. Let's try again";
                    }
                }
            }
        }
    }
}
