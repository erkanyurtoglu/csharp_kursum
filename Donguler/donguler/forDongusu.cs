using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donguler
{
    public partial class forDongusu : Form
    {
        public forDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int'ı içeride tanımlamak yerine dışarıda da int=i şeklinde tanımlanabilir.

            for (int i = 0; i < 10; i++)
            {
                ankara.Items.Add("Merhaba Ankara");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                sayilar.Items.Add(i);
            }
        }
    }
}
