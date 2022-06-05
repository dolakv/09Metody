using PoleUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
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
            int n = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(textBox2.Text);
            int[] pole = Pole.Generuj(n, -100, 100);
            pole = Pole.Vypocet(pole, x);
            foreach (int cislo in pole)
            {
                listBox2.Items.Add(cislo);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
