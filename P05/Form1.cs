using MatematikaUtil;
using RetezUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            int pocet = 0;
            int soucet = 0;
            Retez.ObsahujeCifru(text, out pocet, out soucet);
            if (Matematika.Prvocislo(soucet))
            {
                MessageBox.Show("soucet neni prvocislo");

            }
            else
            {
                MessageBox.Show("soucet je prvocislo");
            }
            MessageBox.Show("soucet je " + soucet);
            MessageBox.Show("pocet je " + pocet);
        }
    }
}
