﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulAereas
{
    public partial class GolSplash : Form
    {
        GolLogin login = new GolLogin();
        public GolSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
            timer1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
