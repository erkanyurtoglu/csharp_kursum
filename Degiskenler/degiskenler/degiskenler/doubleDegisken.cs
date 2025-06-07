using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenler
{
    public partial class doubleDegisken : Form
    {
        public doubleDegisken()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3, ortalama;
            sayi1 = 60;
            sayi2 = 70;
            sayi3 = 79;
            label1.Text = sayi1.ToString();
            label2.Text = "+";
            label3.Text = sayi2.ToString();
            label4.Text = "+";
            label5.Text = sayi3.ToString();
            label6.Text = "=";
            ortalama = (sayi1+sayi2+sayi3)/3;
            label7.Text = ortalama.ToString("0.000"); 

        }
    }
}
