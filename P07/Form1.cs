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

namespace P07
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
            int pocetmalych = 0;
            int pocetcifer = 0;
            int pocetostatnich = 0;
            if (Retez.JeAlfanum(text, out pocetmalych, out pocetcifer, out pocetostatnich))
            {
                MessageBox.Show("cislo je alfanumericke");

            }
            else
            {
                MessageBox.Show("cislo neni alfanumericke");
            }
            MessageBox.Show("pocet malych pismen je " + pocetmalych);
            MessageBox.Show("pocet cifer je " + pocetcifer);
            MessageBox.Show("pocet ostatnich znaku je " + pocetostatnich);
        }
    }
}
