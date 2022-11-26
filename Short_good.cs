using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;
using System.Windows.Media;

[assembly:DisableDpiAwareness]

namespace Record_and_prediction
{
    public partial class Short_good : UserControl
    {
        Product product;
        List<bool> changed = new bool[9]{false,false,false,false,false,false,false,false,false}.ToList();
        string[] months = new string[] {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Авнгуст",
                "Сеньтябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"
        };
        int list_index;
        Goods_list goods_List;
        bool isBeingEdited = false;
        public string set_measures
        {
            set { measure.Items.Add(value); }
        }
        public string set_category
        {
            set { category.Items.Add(value); }
        }
        public Short_good()
        {
            InitializeComponent();
        }
        public Short_good(Product _product, int _list_index, Goods_list _goods_List)
        {
            InitializeComponent();
            product = _product;
            list_index = _list_index;
            goods_List = _goods_List;
            work_name.Text = _product.work_name;
            print_name.Text = _product.print_name;
            code.Text = _product.code;
            article.Text = Convert.ToString(_product.article);
            amount.Text = Convert.ToString(_product.amount);
            category.Text = _product.category;
            price.Text = Convert.ToString(_product.price);
            measure.Text = _product.measure;
            volume.Text = Convert.ToString(_product.sold_volume);

            if (product.prognoze != -1)
            {
                prognose.Text = Convert.ToString(product.prognoze);
                buy.Text = Convert.ToString(product.buy);
            }
            else
            {
                prognose.Text = "---";
                buy.Text = "---";
            }

            work_name.Visible = false;
            print_name.Visible = false;
            code.Visible = false;
            article.Visible = false;
            amount.Visible = false;
            category.Visible = false;
            price.Visible = false;
            measure.Visible = false;
            volume.Visible = false;
            prognose.Visible = false;
            buy.Visible = false;

            work_name_label.Visible = false;
            print_name_label.Visible = false;
            code_label.Visible = false;
            article_label.Visible = false;
            amount_label.Visible = false;
            category_label.Visible = false;
            price_label.Visible = false;
            measure_label.Visible = false;
            volume_label.Visible = false;
            prognose_label.Visible = false;
            buy_label.Visible = false;

            rubles_1.ForeColor = System.Drawing.Color.White;
            rubles_2.ForeColor = System.Drawing.Color.White;
            rubles_3.ForeColor = System.Drawing.Color.White;

            work_name_display_content.Text = work_name.Text;
            code_display_content.Text = code.Text;
            article_display_content.Text = article.Text;
            amount_display_content.Text = amount.Text;
            category_display_content.Text = category.Text;
            price_display_content.Text = price.Text;
            measure_display_content.Text = measure.Text;
            measure_display_content_2.Text = measure.Text;
            volume_display_content.Text = volume.Text;
            prognose_display_content.Text = prognose.Text;
            buy_display_content.Text = buy.Text;

            category.Items.AddRange(Globals.categories.ToArray());
            measure.Items.AddRange(Globals.measures.ToArray());
            Create_Graphic(product);
        }

        public void Create_Graphic(Product product)
        {
            if (product.prognoze != -1)
            {
                graphic.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Месяц",
                    Labels = months.Concat(months).ToList()
                });
                graphic.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Значение",
                    LabelFormatter = value => value.ToString("C")
                });
                graphic.LegendLocation = LiveCharts.LegendLocation.Bottom;
                SeriesCollection series = new SeriesCollection();
                var double_months = months.Concat(months);
                series.Add(new LineSeries() { Title = "График продаж", Values = new ChartValues<int>(product.history) });
                graphic.Series = series;
            }
            else
                graphic.Visible = false;
        }

        private void work_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Short_good_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void article_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
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
            if (l== ';')
            {
                MessageBox.Show("При вводе в это поле нельзя использовать знак запятой", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            int temp = 0;
            if ((l == '.' || !int.TryParse(l.ToString(), out temp)) && l != '\b')
            {
                MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
            string new_price = price.Text;
            double temp = 0;
            if (new_price != product.price.ToString())
                if (!double.TryParse(new_price, out temp))
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                else
                    changed[4] = true;
            else
                changed[4] = false;
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            string new_amount = amount.Text;
            int temp = 0;
            if (new_amount != product.amount.ToString())
                if (!int.TryParse(new_amount, out temp))
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                else
                    changed[7] = true;
            else
                changed[7] = false;
        }
        private void volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            int temp = 0;
            if ((l == '.' && !int.TryParse(l.ToString(), out temp) && l != '\b'))
            {
                MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void volume_Leave(object sender, EventArgs e)
        {
            int temp = 0;
            string new_volume = volume.Text;
            if (new_volume != product.sold_volume.ToString())
                if (!int.TryParse(volume.Text, out temp))
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                else
                    changed[8] = true;
            else
                changed[8] = false;
        }

        private void write_change_to_csv()
        {
            using (TextFieldParser csvParser = new TextFieldParser(Globals.user.path_to_data, Encoding.GetEncoding(1251)))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { ";" });
                csvParser.HasFieldsEnclosedInQuotes = false;

                string line;
                List<String> lines = new List<String>();
                lines.Add(csvParser.ReadLine());
                int i = 1;
                while ((line = csvParser.ReadLine()) != null)
                {
                    if (i == list_index + 1)
                        lines.Add(work_name.Text + ';' + print_name.Text + ';' + code.Text + ';' + article.Text + ';' + amount.Text + ';' + price.Text + ';' + measure.Text + ';' + category.Text + ';' + volume.Text);
                    else
                        lines.Add(line);
                    i++;
                }
                using (StreamWriter writer = new StreamWriter(Globals.user.path_to_data, false, Encoding.GetEncoding(1251)))
                {
                    foreach (string _line in lines)
                        writer.WriteLine(_line);
                }
            }
        }

        private void work_name_Leave(object sender, EventArgs e)
        {
            string new_work_name = work_name.Text;
            if (!new_work_name.Equals(product.work_name))
                changed[0] = true;
            else
                changed[0] = false;
        }

        private void print_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string new_category = category.Text;
            if (!new_category.Equals(product.category))
                changed[6] = true;
            else
                changed[6] = false;
        }

        private void code_Leave(object sender, EventArgs e)
        {
            string new_code = code.Text;
            if (new_code.Equals(product.code))
                changed[2] = true;
            else
                changed[2] = false;
        }

        private void measure_Leave(object sender, EventArgs e)
        {
            string new_measure = measure.Text;
            if (!new_measure.Equals(product.measure))
                changed[8] = true;
            else
                changed[8] = false;
        }

        private void print_name_Leave(object sender, EventArgs e)
        {
            string new_print_name = print_name.Text;
            if (!new_print_name.Equals(product.print_name))
                changed[1] = true;
            else
                changed[1] = false;
        }

        private void article_Leave(object sender, EventArgs e)
        {
            string new_article = article.Text;
            if (!new_article.Equals(product.article))
                changed[3] = true;
            else
                changed[3] = false;
        }

        private void measure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string new_measure = measure.Text;
            if (!new_measure.Equals(product.measure))
                changed[8] = true;
            else
                changed[8] = false;
        }

        private void category_Leave(object sender, EventArgs e)
        {
            string new_category = category.Text;
            if (!new_category.Equals(product.category))
                changed[6] = true;
            else
                changed[6] = false;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (isBeingEdited)
            {
                edit_button.Text = "Редактировать";
                isBeingEdited = false;
                
                work_name.Visible = false;
                print_name.Visible = false;
                code.Visible = false;
                article.Visible = false;
                amount.Visible = false;
                category.Visible = false;
                price.Visible = false;
                measure.Visible = false;
                volume.Visible = false;
                prognose.Visible = false;
                buy.Visible = false;

                work_name_label.Visible = false;
                print_name_label.Visible = false;
                code_label.Visible = false;
                article_label.Visible = false;
                amount_label.Visible = false;
                category_label.Visible = false;
                price_label.Visible = false;
                measure_label.Visible = false;
                volume_label.Visible = false;
                prognose_label.Visible = false;
                buy_label.Visible = false;

                code_display_label.Visible = true;
                article_display_label.Visible = true;
                amount_display_label.Visible = true;
                category_display_label.Visible = true;
                price_display_label.Visible = true;
                volume_display_label.Visible = true;
                prognose_display_label.Visible = true;
                buy_display_label.Visible = true;

                work_name_display_content.Visible = true;
                code_display_content.Visible = true;
                article_display_content.Visible = true;
                amount_display_content.Visible = true;
                category_display_content.Visible = true;
                price_display_content.Visible = true;
                measure_display_content.Visible = true;
                measure_display_content_2.Visible = true;
                volume_display_content.Visible = true;
                prognose_display_content.Visible = true;
                buy_display_content.Visible = true;
                rubles_1.Visible = true;
                rubles_2.Visible = true;
                rubles_3.Visible = true;

                work_name_display_content.Text = work_name.Text;
                code_display_content.Text = code.Text;
                article_display_content.Text = article.Text;
                amount_display_content.Text = amount.Text;
                category_display_content.Text = category.Text;
                price_display_content.Text = price.Text;
                measure_display_content.Text = measure.Text;
                measure_display_content_2.Text = measure.Text;
                volume_display_content.Text = volume.Text;
                prognose_display_content.Text = prognose.Text;
                buy_display_content.Text = buy.Text;

                if (changed.Any(x => x == true))
                {
                    try
                    {
                        product.history[23] = Convert.ToInt32(volume.Text);
                        product = new Product(work_name.Text, print_name.Text, Convert.ToInt32(article.Text), code.Text,
                            Convert.ToInt32(amount.Text), Convert.ToDouble(price.Text), measure.Text, category.Text, Convert.ToInt32(volume.Text),
                            Convert.ToInt32(prognose.Text), Convert.ToInt32(buy.Text), product.history);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вы не заполнили одно из полей", "Ошибка", MessageBoxButtons.OK);
                    }
                    Globals.products[list_index] = product;
                    Globals.user.products[list_index] = product;
                    goods_List.buttonlist[list_index].Text = work_name.Text;
                    write_change_to_csv();
                    changed.Select(x => x = false);
                }
            }
            else
            {
                edit_button.Text = "Сохранить";
                isBeingEdited = true;

                work_name.Visible = true;
                print_name.Visible = true;
                code.Visible = true;
                article.Visible = true;
                amount.Visible = true;
                category.Visible = true;
                price.Visible = true;
                measure.Visible = true;
                volume.Visible = true;
                prognose.Visible = true;
                buy.Visible = true;

                work_name_label.Visible = true;
                print_name_label.Visible = true;
                code_label.Visible = true;
                article_label.Visible = true;
                amount_label.Visible = true;
                category_label.Visible = true;
                price_label.Visible = true;
                measure_label.Visible = true;
                volume_label.Visible = true;
                prognose_label.Visible = true;
                buy_label.Visible = true;

                code_display_label.Visible = false;
                article_display_label.Visible = false;
                amount_display_label.Visible = false;
                category_display_label.Visible = false;
                price_display_label.Visible = false;
                volume_display_label.Visible = false;
                prognose_display_label.Visible = false;
                buy_display_label.Visible = false;

                work_name_display_content.Visible = false;
                code_display_content.Visible = false;
                article_display_content.Visible = false;
                amount_display_content.Visible = false;
                category_display_content.Visible = false;
                price_display_content.Visible = false;
                measure_display_content.Visible = false;
                measure_display_content_2.Visible = false;
                volume_display_content.Visible = false;
                prognose_display_content.Visible = false;
                buy_display_content.Visible = false;
                rubles_1.Visible = false;
                rubles_2.Visible = false;
                rubles_3.Visible = false;
            }
        }
    }
}
