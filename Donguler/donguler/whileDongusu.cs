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
    public partial class whileDongusu : Form
    {
        public whileDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 10) 
            {
                listBox1.Items.Add("Merhaba Dünya");
                listBox2.Items.Add(i);
                i++;
                
            }
        }
    }
}
