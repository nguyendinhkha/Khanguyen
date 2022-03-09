using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a1 = float.Parse(num1.Text.Trim());
            float a2 = float.Parse(num2.Text.Trim());
            float a3 = float.Parse(num3.Text.Trim());
            if (a1 >= a2)
            {
                if (a2 >= a3)
                {
                    largest.Text = a1.ToString();
                    smallest.Text = a3.ToString();
                }
                else
                {
                    if (a1 >= a3)
                    {
                        largest.Text = a1.ToString();
                    }
                    else
                    {
                        largest.Text = a3.ToString();
                    }
                    smallest.Text = a2.ToString();
                }
            }
            else
            {
                if (a1 >= a3)
                {
                    largest.Text = a2.ToString();
                    smallest.Text = a3.ToString();
                }
                else
                {
                    if (a2 >= a3)
                    {
                        largest.Text = a2.ToString();
                    }
                    else
                    {
                        largest.Text = a3.ToString();
                    }
                    smallest.Text = a1.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Text = num2.Text = num3.Text = largest.Text = smallest.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
