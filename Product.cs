using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_and_prediction
{
    public class Product
    {
        public string work_name;
        public string print_name;
        public int article;
        public string code;
        public int amount;
        public double price;
        public string measure;
        public int sold_volume;
        public string category;
        public List<int> history;
        public int prognoze = -1;
        public int buy;

        public Product(string in_work_name, string in_print_name, int in_article, string in_code, int in_amount, double in_price, string in_measure, string in_category, int in_sold_volume)
        {
            work_name = in_work_name;
            print_name = in_print_name;
            article = in_article;
            code = in_code;
            amount = in_amount;
            price = in_price;
            measure = in_measure;
            sold_volume = in_sold_volume;
            category = in_category;
        }
        public Product(string in_work_name, string in_print_name, int in_article, string in_code, int in_amount, double in_price, 
            string in_measure, string in_category, int in_sold_volume, int _prognose, int _buy, List<int> _history)
        {
            work_name = in_work_name;
            print_name = in_print_name;
            article = in_article;
            code = in_code;
            amount = in_amount;
            price = in_price;
            measure = in_measure;
            sold_volume = in_sold_volume;
            category = in_category;
            prognoze = _prognose;
            buy = _buy;
            history = _history;
        }
        public Product(string[] fields)
        {
            work_name = fields[0];
            print_name = fields[1];
            code = fields[2];
            article = Convert.ToInt32(fields[3]);
            amount = Convert.ToInt32(fields[4]);
            price = Convert.ToDouble(fields[5]);
            measure = fields[6];
            category = fields[7];
            sold_volume = Convert.ToInt32(fields[8]);
            if (!Globals.categories.Contains(category))
                Globals.categories.Add(category);
            if (!Globals.measures.Contains(measure))
                Globals.measures.Add(measure);
        }
    }
}
