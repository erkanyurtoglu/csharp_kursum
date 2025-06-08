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
    public partial class foreachDongusu : Form
    {
        public foreachDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] meyveler = {"Elma", "Armut", "Mango", "Ananas", "Erik"};
            foreach (string m in meyveler)
            {
                listBox1.Items.Add(m);
            }
        }
    }
}
