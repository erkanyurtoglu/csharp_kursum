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
    public partial class intDegisken : Form
    {
        public intDegisken()
        {
            InitializeComponent();
        }

        private void intDegisken_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 4;
            string toplamaIsareti = "+";
            string esittirIsareti = "=";
            toplam = sayi1 + sayi2;

            label1.Text = sayi1.ToString();
            label2.Text = toplamaIsareti;
            label3.Text = sayi2.ToString();
            label4.Text = esittirIsareti;
            label5.Text = toplam.ToString();

        }
    }
}
