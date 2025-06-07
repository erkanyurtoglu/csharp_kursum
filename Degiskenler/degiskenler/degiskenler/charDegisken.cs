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
    public partial class charDegisken : Form
    {
        public charDegisken()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char takim;
            takim = 'g';
            label1.Text = takim.ToString();
        }
    }
}
