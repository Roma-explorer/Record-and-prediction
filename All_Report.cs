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
    public partial class All_Report : UserControl
    {
        public All_Report()
        {
            InitializeComponent();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void All_Report_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            foreach (Product product in Globals.products)
            {
                string result;
                string buy;
                if (product.prognoze != -1)
                    result = Convert.ToString(product.prognoze);
                else
                    result = "Недостаточно данных";
                if (result == "Недостаточно данных")
                    buy = result;
                else
                    buy = Convert.ToString(product.buy);
                table.Rows.Add(product.work_name, product.article, product.price, product.amount, product.sold_volume, product.category, result, buy);
            }
        }
    }
}
