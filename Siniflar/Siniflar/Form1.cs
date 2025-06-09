using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba car = new Araba();
            car.marka = "Renault";
            car.hiz = 260;
            car.motor = 1.5;
            car.durum = 's';
            car.fiyat = 930000;
            car.YIL = -2017;
            car.RENK = "beyaz";
            car.plaka = "06 FDH 733";
            car.muayene = 2027;
            car.aracSahibi = "Erkan Yurtoğlu";

            label1.Text = car.marka;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.durum.ToString();
            label5.Text = car.fiyat.ToString();
            label6.Text = car.YIL.ToString();
            label7.Text = car.RENK;
            label8.Text = car.plaka;
            label9.Text = car.muayene.ToString();
            label10.Text = car.aracSahibi;

        }
    }
}
