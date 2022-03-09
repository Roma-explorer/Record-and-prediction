using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_and_prediction
{
    public partial class Form1 : Form
    {
        private static Form1 form = null;
        Register reg;
        public SplitterPanel Split_panel3
        {
            get { return ProductDataSplit.Panel2; }
        }
        public Form1(Register _reg)
        {
            InitializeComponent();
            form = this;
            reg = _reg;
            form.Text = Globals.user.org_name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Goods_list goods_list = new Goods_list(this);

            Controls_manipulate.SwitchView(ProductDataSplit.Panel1, goods_list, this);

        }

        private void Show_goods_button_Click(object sender, EventArgs e)
        {
            if (Controls_manipulate.CanCurrentViewClose(ProductDataSplit.Panel1))
            {
                Goods_list goods_list = new Goods_list(this);

                Controls_manipulate.SwitchView(ProductDataSplit.Panel1, goods_list, this);
            }
            else
            {
                MessageBox.Show("Current View can not close!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reg.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Controls_manipulate.CanCurrentViewClose(ProductDataSplit.Panel1))
            {
                Record_choices choices = new Record_choices(this);

                Controls_manipulate.SwitchView(ProductDataSplit.Panel1, choices, this);
            }
            else
            {
                MessageBox.Show("Current View can not close!");
            }
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                reg.Show();
                this.Close();
            }
        }
    }

    public class Controls_manipulate
    {
        
        public static bool Can_close(UserControl userControl) /// Write later
        {
            return true;
        }

        public static bool CanCurrentViewClose(SplitterPanel panel)
        {
            if (panel.Controls.Count == 0)
                return true;

            UserControl v = panel.Controls[0] as UserControl;
            return Can_close(v);
        }

        public static void SwitchView(SplitterPanel panel, UserControl newView, Form1 form)
        {
            if (panel.Controls.Count > 0)
            {
                UserControl oldView = panel.Controls[0] as UserControl;
                panel.Controls.Remove(oldView);
                oldView.Dispose();
                form.Split_panel3.Controls.Clear();
            }
            panel.Controls.Add(newView);
        }
    }
}
