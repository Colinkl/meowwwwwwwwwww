using System;
using System.Drawing;
using System.Media;

using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class meow : Form
    {
        string meoww = "";
        public meow()
        {
            InitializeComponent();

        }
 
        SoundPlayer bass = new SoundPlayer("bassboosted.wav");
        public void ButtonPress(int id)
        {
            meoww = meoww + Convert.ToString(id);
            switch (id)
            {
                case 1:
                    button2.Enabled = false;
                    break;
                case 2:
                    button3.Enabled = false;
                    break;
                case 3:
                    button4.Enabled = false;
                    break;
                case 4:
                    button5.Enabled = false;
                    break;
                case 5:
                    button6.Enabled = false;
                    break;
                case 6:
                    button7.Enabled = false;
                    break;
                case 7:
                    button8.Enabled = false;
                    break;
                case 8:
                    button9.Enabled = false;
                    break;
                case 9:
                    button1.Enabled = false;
                    break;
                default:
                    button1.Enabled = false;
                    break;

            }
            if (meoww == "88005553535")
            {
                bass.Play();
            }
        }
            private void Form1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Enabled = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) => ButtonPress(1);

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonPress(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonPress(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonPress(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonPress(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonPress(5);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonPress(9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonPress(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonPress(7);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) => ButtonPress(0);
    }
}
