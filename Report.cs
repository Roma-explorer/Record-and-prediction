using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public partial class Report : UserControl
    {
        public string category;
        public string sort;
        public Report()
        {
            InitializeComponent();
            category_box.Items.AddRange(Globals.categories.ToArray());
            category_box.Items.Add("Все");
            sort_box.Items.Add("По числу продаж за последний месяц");
            sort_box.Items.Add("По прогнозу на следующий месяц");
            sort_box.Items.Add("По прибыли");
            sort_box.Items.Add("По чистой прибыли");
        }

        private void category_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = category_box.Text;
            if (sort_box.Text != string.Empty)
                Form_table();
        }

        private void sort_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = sort_box.Text;
            if (category_box.Text != string.Empty)
                Form_table();
        }

        public void Form_table()
        {
            table.Rows.Clear();
            if (category == "Все")
            {
                List<Product> to_display;
                if (sort == "По числу продаж за последний месяц")
                    to_display = Globals.products.OrderByDescending(x => x.sold_volume).ToList();
                else
                    if (sort == "По прогнозу на следующий месяц")
                        to_display = Globals.products.OrderByDescending(x => x.prognoze).ToList();
                else
                    if (sort == "По прибыли")
                        to_display = Globals.products.OrderByDescending(x => x.sold_volume * x.price).ToList();
                    else
                        to_display = Globals.products.OrderByDescending(x => x.sold_volume * x.price - x.sold_volume * x.prime_cost).ToList();
                foreach (Product product in to_display)
                {
                    string result = "";
                    string buy = "";
                    Check_history(ref result, ref buy, product);
                    table.Rows.Add(product.work_name, product.article, product.price, product.amount, 
                        product.sold_volume, product.category, result, buy, product.sold_volume * product.price, 
                        product.sold_volume * product.price - product.sold_volume * product.prime_cost);
                }
            }
            else
            {
                List<Product> to_display;
                if (sort == "По числу продаж за последний месяц")
                    to_display = Globals.products.Where(y => y.category == category).ToList().OrderByDescending(x => x.sold_volume).ToList();
                else
                    if (sort == "По прогнозу на следующий месяц")
                        to_display = Globals.products.Where(y => y.category == category ).ToList().OrderByDescending(x => x.prognoze).ToList();
                    else
                        if (sort == "По прибыли")
                            to_display = Globals.products.OrderByDescending(x => x.sold_volume * x.price).ToList();
                        else
                            to_display = Globals.products.OrderByDescending(x => x.sold_volume * x.price - x.sold_volume * x.prime_cost).ToList();
                foreach (Product product in to_display)
                {
                    string result = "";
                    string buy = "";
                    Check_history(ref result, ref buy, product);
                    table.Rows.Add(product.work_name, product.article, product.price, product.amount, 
                        product.sold_volume, product.category, result, buy, product.sold_volume * product.price, 
                        product.sold_volume * product.price - product.sold_volume * product.prime_cost);
                }
            }
        }

        public static void Check_history(ref string result,ref string buy, Product product)
        {
            if (product.prognoze != -1)
                result = Convert.ToString(product.prognoze);
            else
                result = "Недостаточно данных";
            if (result == "Недостаточно данных")
                buy = result;
            else
                buy = Convert.ToString(product.buy);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
