﻿using System;
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
    public partial class kararYapilariDonguler : Form
    {
        public kararYapilariDonguler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i <=10; i++)
            {
                if(i%3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            */

            for (int i = 1; i <= 100; i++)
            {
                if(i%5 == 0 && i%7 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
