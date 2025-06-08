using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class degerDonduren : Form
    {
        public degerDonduren()
        {
            InitializeComponent();
        }

        int topla(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
            return sayi3; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = topla(4, 6).ToString();
        }
    }
}
