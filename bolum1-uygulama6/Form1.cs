using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1_uygulama6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 50;

            int toplam;
            toplam = sayi1 + sayi2;
            MessageBox.Show("50" + toplam.ToString());
        }
    }
}
