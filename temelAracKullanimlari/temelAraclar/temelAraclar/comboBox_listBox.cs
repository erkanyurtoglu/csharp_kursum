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
    public partial class comboBox_listBox : Form
    {
        public comboBox_listBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            MessageBox.Show("Şehir Eklendi");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_listBox_Load(object sender, EventArgs e)
        {

        }
    }
}
