using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public class User
    {
        public string login = null;
        public string password = null;
        public string org_name = null;
        public string path_to_data = null;
        public string path_to_record = null;
        public List<Product> products;
        public static List<int[]> records;
        public static List<int> prognozes;
        public User(string _login, string _password, string _org_name, string _to_data, string _to_record)
        {
            login = _login;
            password = _password;
            org_name = _org_name;
            path_to_data = _to_data;
            path_to_record = _to_record;
            prognozes = Dowload_data(path_to_record);
            products = Download_products(path_to_data);
        }

        public static List<Product> Download_products(string file_path)
        {
            List<Product> products = new List<Product>();
            try
            {
                using (TextFieldParser csvParser = new TextFieldParser(file_path, Encoding.Default))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { ";" });
                    csvParser.HasFieldsEnclosedInQuotes = false;
                    csvParser.ReadLine();

                    try
                    {
                        int i = 0;
                        while (!csvParser.EndOfData)
                        {
                            string[] fields = csvParser.ReadFields();
                            var product = new Product(fields);
                            if (prognozes.Count > i)
                            {
                                product.prognoze = prognozes[i];
                                product.history = records[i].ToList();
                            }
                            product.buy = product.prognoze - product.amount < 0 ? 0 : product.prognoze - product.amount;
                            products.Add(product);
                            i++;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Файл с данными о товаре был повреждён", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                return products;
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("Файл с данными не был найден", "Ошибка", MessageBoxButtons.OK);
            }
            return products;
        }

        public static List<int> Dowload_data(string file_path)
        {
            List<int[]> sell_records = new List<int[]>();
            List<int> prognoze = new List<int>();
            try
            {
                using (TextFieldParser csvParser = new TextFieldParser(file_path, Encoding.Default))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { ";" });
                    csvParser.HasFieldsEnclosedInQuotes = false;
                    csvParser.ReadLine();
                    Read_fields(csvParser, sell_records, prognoze);
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("Файл с данными пользователя не найден", "Ошибка", MessageBoxButtons.OK);
            }
            return prognoze;
        }
        public static void Read_fields(TextFieldParser csvParser, List<int[]> sell_records, List<int> prognoze)
        {
            try
            {
                while (!csvParser.EndOfData)
                    Read_field(csvParser, sell_records);
                records = sell_records;
                foreach (int[] record in sell_records)
                    prognoze.Add(Prediction.Host_Winter(record.ToList()));
            }
            catch (Exception)
            {
                MessageBox.Show("Файл с данными о продажах был повреждён", "Ошибка", MessageBoxButtons.OK);
            }
        }

        public static void Read_field(TextFieldParser csvParser, List<int[]> sell_records)
        {
            List<string> fields = csvParser.ReadFields().ToList();
            fields.RemoveRange(25, fields.Count - 25);
            var record_for_item = fields.GetRange(1, fields.Count - 1);
            List<int> record_for_item_int = new List<int>();
            for (int i = 0; i < record_for_item.Count; i++)
                record_for_item_int.Add(Convert.ToInt32(record_for_item[i]));
            sell_records.Add(record_for_item_int.ToArray());
        }
    }
}
