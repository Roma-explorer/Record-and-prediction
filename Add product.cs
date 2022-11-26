using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public partial class save_button : Form
    {
        List<bool> added = new bool[9] { false, false, false, false, false, false, false, false, false }.ToList();
        Goods_list goods_List;
        public save_button(Goods_list _goods_List)
        {
            InitializeComponent();
            goods_List = _goods_List;
            category.Items.AddRange(Globals.categories.ToArray());
            measure.Items.AddRange(Globals.measures.ToArray());
        }
        private void article_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int temp = 0;
            if (!int.TryParse(l.ToString(), out temp) && l != '\b')
            {
                MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void print_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == ';')
            {
                MessageBox.Show("При вводе в это поле нельзя использовать знак запятой", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            int temp = 0;
            if ((l == '.' || !int.TryParse(l.ToString(), out temp))&& l != '\b')
            {
                MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        private void price_Leave(object sender, EventArgs e)
        {
            string new_price = price.Text;
            double temp = 0;
            if (!double.TryParse(new_price, out temp))
            {
                MessageBox.Show("Введено неверное число", "Неверный ввод", MessageBoxButtons.OK);
                added[4] = true;
            }
            else
                added[4] = false;
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(amount.Text, out temp))
            {
                MessageBox.Show("Введено неверное число", "Неверный ввод", MessageBoxButtons.OK);
                added[7] = true;
            }
            else
                added[7] = false;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            if (work_name.Text != "" && print_name.Text != "" && code.Text != "" && article.Text != "" && 
                amount.Text != "" && category.Text != "" && price.Text != "" && measure.Text != "" && volume.Text != "")
            {
                if (added.Any(x => x == true))
                {
                    MessageBox.Show("В одном из полей некорректный ввод", "Сообщение", MessageBoxButtons.OK);
                    return;
                }
                string line = string.Concat(work_name.Text, ';', print_name.Text, ';', code.Text, ';', article.Text, ';', amount.Text, ';', price.Text, ';', measure.Text, ';', category.Text, ';', volume.Text, '\n');
                File.AppendAllText(Globals.user.path_to_data, line, Encoding.GetEncoding(1251));
                Product product = new Product(work_name.Text, print_name.Text, Convert.ToInt32(article.Text), code.Text,
                    Convert.ToInt32(amount.Text), Convert.ToDouble(price.Text), measure.Text, category.Text, Convert.ToInt32(volume.Text));
                goods_List.Add_button(product);
                Globals.user.products.Add(product);
                Globals.products.Add(product);
                if (!Globals.categories.Contains(category.Text))
                    Globals.categories.Add(category.Text);
                if (!Globals.measures.Contains(measure.Text))
                    Globals.measures.Add(measure.Text);
                MessageBox.Show("Товар добавлен", "Сообщение", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            int temp = 0;
            if ((l == '.' || !int.TryParse(l.ToString(), out temp)) && l != '\b')
            {
                MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void volume_Leave(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(amount.Text, out temp))
            {
                MessageBox.Show("Введено неверное число", "Неверный ввод", MessageBoxButtons.OK);
            }
        }
    }
}
