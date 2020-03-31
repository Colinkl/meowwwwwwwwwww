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
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        private double x, y, z, g;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void xbox_TextChanged(object sender, EventArgs e)
        {
            x = double.Parse(xbox.Text);
        }

        private void ybox_TextChanged(object sender, EventArgs e)
        {
            y = double.Parse(ybox.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void zbox_TextChanged(object sender, EventArgs e)
        {
            z = double.Parse(zbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine + "x= " +x;
            richTextBox1.Text += Environment.NewLine + "y= " + y;
            richTextBox1.Text += Environment.NewLine + "z= " + z;
            g = (Math.Pow(y, (x + 1)) / (Math.Pow(Math.Abs(y - 2), (1 / 3)) + 3)) + ((((x + (0.5 * y)) * (Math.Pow((x + 1), (-1 / Math.Sin(z))))) / ((2 * Math.Abs(x + y)))));
            richTextBox1.Text += Environment.NewLine + "g= " + g;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }     
                
    }
}
