using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezarvasyon
{
    public partial class Form2 : Form
    {
        int su, ayran, kola, kebab, burger;

        private void button4_Click(object sender, EventArgs e)
        {
            kebab++;
            label4.Text = "Adet: " + kebab;
            label6.Text = "Tutar : " + ((su * 91) + (ayran * 83) + (kola * 95) + (kebab * 102) + (burger * 87)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            burger++;
            label5.Text = "Adet: " + burger;
            label6.Text = "Tutar : " + ((su * 91) + (ayran * 83) + (kola * 95) + (kebab * 102) + (burger * 87)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            su = 0;
            ayran = 0;
            kola = 0;
            kebab = 0;
            burger = 0;
            label1.Text = "Adet: 0";
            label2.Text = "Adet: 0";
            label3.Text = "Adet: 0";
            label4.Text = "Adet: 0";
            label5.Text = "Adet: 0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kola++;
            label3.Text = "Adet: " + kola;
            label6.Text = "Tutar : " + ((su * 91) + (ayran * 83) + (kola * 95) + (kebab * 102) + (burger * 87)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ayran++;
            label2.Text = "Adet: " + ayran;
            label6.Text = "Tutar : " + ((su * 91) + (ayran * 83) + (kola * 95) + (kebab * 102) + (burger * 87)).ToString();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            su++;
            label1.Text = "Adet: "+su;
            label6.Text = "Tutar : " + ((su * 91) + (ayran * 83) + (kola * 95) + (kebab * 102) + (burger * 87)).ToString();
        }
    }
}
