using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler
{
    public partial class diziElemanListele : Form
    {
        public diziElemanListele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string[] sehirler = {"Ankara", "Denizli", "İstanbul", "İzmir", "Nevşehir"};
            for (int i = 0; i < sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }

            /*
            int[] sayilar = {4, 3, 5, 6, 8, 10, 12, 14, 1 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
            */
        }
    }
}
