﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compiler_Prroject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();
            form2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            this.Hide();
            form3.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            this.Hide();
            form4.ShowDialog();
            Close();
        }
    }
}
