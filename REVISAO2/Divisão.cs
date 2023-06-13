using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REVISAO2
{
    public partial class Divisão : Form
    {
        public Divisão()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_num1.Text);
            int b = Convert.ToInt32(tx_num2.Text);

            int c = a / b;

            MessageBox.Show(c.ToString());
        }
    }
}
