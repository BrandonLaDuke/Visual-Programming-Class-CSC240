﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
    }
}