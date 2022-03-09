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

namespace Record_and_prediction
{
    public partial class Goods_list : UserControl
    {
        public List<Button> buttonlist = new List<Button>();
        Form1 main_form;
        public Goods_list(Form1 form1)
        {
            InitializeComponent();
            main_form = form1;
            Display_products();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            save_button add_Product = new save_button(this);
            add_Product.Show();
        }

        private void download_goods_Click(object sender, EventArgs e)
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
                        string file_path = openFileDialog1.FileName;
                        User.Download_products(file_path);
                        Display_products();
                    }
                    catch (Exception)
                    {
                        this.Text = "Sorry, something went wrong. Let's try again";
                    }
                }
            }
        }

        

        public List<Product> Download_goods(string path)
        {
            List<Product> products = new List<Product>();
            using (var reader = new StreamReader(path, Encoding.Default))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    products.Add(new Product(values));
                }
            }
            return products;
        }

        public void Display_products()
        {
            if (Globals.products != null)
            {
                for (int i = 0; i < Globals.products.Count; i++)
                {
                    Add_button(Globals.products[i]);
                }
            }
            else
                this.Text = "No products";
        }

        public void Add_button(Product product)
        {
            Button b = new Button();
            b.Text = product.work_name;
            b.Width = flowLayoutPanel1.Width;
            b.Height = 25;
            b.BackColor = Color.LightSteelBlue;
            b.Dock = DockStyle.Top;
            b.AutoEllipsis = true;
            b.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            b.MouseUp += (s, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    int index = buttonlist.FindIndex(x => x.Text == b.Text);
                    Product new_product = Globals.products[index];
                    Short_good product_window = new Short_good(new_product, index, this);
                    Controls_manipulate.SwitchView(main_form.Split_panel3, product_window, main_form);
                }
            };
            flowLayoutPanel1.Controls.Add(b);
            buttonlist.Add(b);
        }

        private void Goods_list_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
