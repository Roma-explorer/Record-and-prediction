﻿using System;
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
            if(product.prognoze != -1)
            {
                prognose.Text = Convert.ToString(product.prognoze);
                buy.Text = Convert.ToString(product.buy);
            }
            else
            {
                prognose.Text = "Недостаточно данных";
                buy.Text = "Недостаточно данных";
            }
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
                //int i = 0;
                var double_months = months.Concat(months);
                //foreach (var month in double_months)
                //{
                //    List<int> values = new List<int>();
                //    values.Add(product.history[i]);
                //    i++;
                //    series.Add(new LineSeries() { Title = double_months.ToString(), Values = new ChartValues<int>(values);
                //}
                //series.Add(new LineSeries() { Title = double_months[0], Values = new ChartValues<int>();
                series.Add(new LineSeries() { Title = "График продаж", Values = new ChartValues<int>(product.history) });
                graphic.Series = series;
                //graphic.

                //graphic.ForeColor = Color.Blue;
                //graphic.Series = new LiveCharts.SeriesCollection(product.history);
                //for (int i = 0; i < product.history.Count; i++)
                //{
                //    graphic.Series[i].ScalesXAt = Convert.ToInt32(months[i % 12]);
                //}
                //graphic.AxisX = months;
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
            {
                if (!double.TryParse(new_price, out temp))
                {
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                }
                else
                {
                    changed[4] = true;
                }
            }
            else
            {
                changed[4] = false;
            }
        }

        private void amount_Leave(object sender, EventArgs e)
        {
            string new_amount = amount.Text;
            int temp = 0;
            if (new_amount != product.amount.ToString())
            {
                if (!int.TryParse(new_amount, out temp))
                {
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                }
                else
                {
                    changed[7] = true;
                }
            }
            else
            {
                changed[7] = false;
            }
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
            {
                if (!int.TryParse(volume.Text, out temp))
                {
                    MessageBox.Show("При вводе в это поле можно использовать цифры", "Неверный ввод", MessageBoxButtons.OK);
                }
                else
                {
                    changed[8] = true;
                }
            }
            else
            {
                changed[8] = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (changed.Any(x => x == true))
            {
                try
                {
                    product.history[23] = Convert.ToInt32(volume.Text);
                    product = new Product(work_name.Text, print_name.Text, Convert.ToInt32(article.Text), code.Text,
                        Convert.ToInt32(amount.Text), Convert.ToDouble(price.Text), measure.Text, category.Text, Convert.ToInt32(volume.Text), Convert.ToInt32(prognose.Text), Convert.ToInt32(buy.Text), product.history);
                    
                }
                catch(Exception)
                {
                    MessageBox.Show("Вы не заполнили одно из полей", "Ошибка", MessageBoxButtons.OK);
                }
                Globals.products[list_index] = product;
                Globals.user.products[list_index] = product;
                goods_List.buttonlist[list_index].Text = work_name.Text;
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
                        if (i == list_index+1)
                        {
                            lines.Add(work_name.Text + ';' + print_name.Text + ';' + code.Text + ';' + article.Text + ';' + amount.Text + ';' + price.Text + ';' + measure.Text + ';' + category.Text + ';' + volume.Text);
                        }
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
                changed.Select(x => x = false);
            }
            else
                MessageBox.Show("Вы ничего не изменили", "Сообщение", MessageBoxButtons.OK);
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
    }
}
