﻿using RetezUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if(Retez.ObsahujeSlovo(out string nejdelsi, out string nejkratsi, text))
            {
                MessageBox.Show("retezec obsahuje aspon 1 slovo");
            }
            else
            {
                MessageBox.Show("retezec neobsahuje ani jedno slovo");
            }
            MessageBox.Show("nejdelsi slovo je " + nejdelsi);
            MessageBox.Show("nejkratsi slovo je " + nejkratsi);
            Retez.Zobraz(text, listBox1);

        }
    }
}
