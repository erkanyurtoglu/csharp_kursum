﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temelAraclar
{
    public partial class pictureBox_masked__dateTime : Form
    {
        public pictureBox_masked__dateTime()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(maskedTextBox3.Text);
            listBox1.Items.Add(maskedTextBox4.Text);
            

            /*
            listBox1.Items.Add(maskedTextBox4.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text 
                + " " + maskedTextBox4.Text);
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}
