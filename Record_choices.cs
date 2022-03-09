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
    public partial class Record_choices : UserControl
    {
        Form1 main_form;
        public Record_choices(Form1 _main_form)
        {
            InitializeComponent();
            main_form = _main_form;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Report record_categorical = new Report();
            Controls_manipulate.SwitchView(main_form.Split_panel3, record_categorical, main_form);
        }

        private void Record_choices_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void All_Click(object sender, EventArgs e)
        {
            All_Report all_Report = new All_Report();
            Controls_manipulate.SwitchView(main_form.Split_panel3, all_Report, main_form);
        }
    }
}
