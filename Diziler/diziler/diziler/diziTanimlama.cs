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
    public partial class diziTanimlama : Form
    {
        public diziTanimlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Erkan", "Zehra", "Atay", "Duru", "Çağan", "Çınar" };
            label1.Text = kisiler[1];

            /*
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7};
            label1.Text = sayilar[3].ToString();
            */
        }
    }
}
