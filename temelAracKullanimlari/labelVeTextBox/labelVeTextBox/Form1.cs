﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelVeTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Erkan YURTOĞLU";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazılım Geliştirici";
            label3.Text = textBox1.Text;
            textBox1.Clear();
        }
    }
}
