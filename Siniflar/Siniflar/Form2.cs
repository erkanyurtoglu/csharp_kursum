using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba car = new Araba();
            car.marka = "Volvo";
            car.hiz = 360;
            car.motor = 2.0;
            car.durum = 's';
            car.fiyat = 1500000;

            label1.Text = car.marka;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.durum.ToString();
            label5.Text = car.fiyat.ToString();
        }
    }
}
