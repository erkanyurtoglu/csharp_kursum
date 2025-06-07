using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapilari
{
    public partial class ifelse : Form
    {
        public ifelse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Erkan")
            {
                label3.Text = "Doğru";
            }
            else 
            {
                label3.Text = "Yanlış";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text);
            if (sayi == 16)
            {
                label4.Text = "Sayı Eşit";
            }
            else 
            {
                label4.Text = "Sayı Eşit Değil";
            }
        }
    }
}
