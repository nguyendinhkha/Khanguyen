using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20520562_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textA.Text);
            int b = Convert.ToInt32(textB.Text);
            int c = Convert.ToInt32(textC.Text);


            int max = 0;
            
            if (a > max)
                max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            int min = a;
            if (b < min)
                min = b;

            if (c < min)
                min = c;

            text_max.Text = Convert.ToString(max);
            text_min.Text = Convert.ToString(min);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
