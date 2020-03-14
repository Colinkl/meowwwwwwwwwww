using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class z4 : Form
    {
        public z4()
        {
            InitializeComponent();
        }
        private double x, y, z;

        private void calculator()
        {
            double f = 0;
            if (sh.Checked)
            {
                f = 0.5 * (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x));
            }
            if (eee.Checked)
            {
                f = Math.Pow(Math.E, x);
            }
            if (sqrr.Checked)
            {
                f = Math.Pow(x, 2);
            }
            double t = 0;
            double d = 0;
            if ((f + y + z) > (x * y * z))
            {
                t = (f + y + z);
                d = x * y * z;
            }
            else
            {
                t = x * y * z;
                d = (f + y + z);
            }
            outss.Text += Environment.NewLine + "x= " + x;
            outss.Text += Environment.NewLine + "y= " + y;
            outss.Text += Environment.NewLine + "z= " + z;
            if (d == 0)
            {
                outss.Text += Environment.NewLine + "div by 0 ";
            }
            else
            {
                double q = t / d;
                outss.Text += Environment.NewLine + "q= " + q;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y = double.Parse(ybox.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            z = double.Parse(zbox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToDouble(xbox.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator();
        }

        private void sqrr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void sh_Checked(object sender, EventArgs e)
        {

        }
    }
}
