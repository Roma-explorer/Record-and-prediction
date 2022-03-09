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
    public partial class Main_menu : UserControl
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
