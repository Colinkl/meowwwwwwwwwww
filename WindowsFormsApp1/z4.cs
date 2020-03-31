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
        double xxxx0, xkkkk, dxxxx, aaaaa, y;
        public  z4()
        {
            InitializeComponent();
        }
        private void catread()
        {
            xxxx0 = Convert.ToDouble(x0.Text);
            xkkkk = Convert.ToDouble(xk.Text);
            dxxxx = Convert.ToDouble(dxx.Text);
            aaaaa = Convert.ToDouble(bx.Text);
        }
        private void catcalc()
        {
            while (xxxx0 <= xkkkk)
            {
                y = (Math.Pow(xxxx0, 2.5) - aaaaa) * (Math.Log(Math.Pow(xxxx0, 2) + 12.7));
                OutBoxx.Text += Environment.NewLine + "x=" + xxxx0 + " y= " + y;
                xxxx0 += dxxxx;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catread();
            catcalc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zz4_Load(object sender, EventArgs e)
        {

        }

        private void x0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
