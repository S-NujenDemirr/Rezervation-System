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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "admin" && textBox2.Text == "123") 
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                }
                else 
                {
                    MessageBox.Show("Giriş yapılamadı");
                }
            }
            catch 
            {
                MessageBox.Show("Giriş yapılamadı");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
