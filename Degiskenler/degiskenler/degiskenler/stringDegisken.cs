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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = "Erkan Yurtoğlu";
            label1.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin1, metin2, metin3;
            metin1 = "Yazılım Geliştirici";
            metin2 = "Pamukkale Üniversitesi";
            metin3 = "Yönetim Bilişim Sistemleri";

            label2.Text = metin1;
            label3.Text = metin2;
            label4.Text = metin3;

        }
    }
}
