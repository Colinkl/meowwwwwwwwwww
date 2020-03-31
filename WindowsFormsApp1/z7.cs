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
    public partial class z7 : Form
    {
        public z7()
        {
            InitializeComponent();
        }

        public int[] meowarray = new int[15];

        private void randButton_Click(object sender, EventArgs e)
        {
            randomgen();
        }

        private void ProccesButton_Click(object sender, EventArgs e)
        {
            proccesor();
        }

        private void InputMassList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OutMassList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randomgen()
        {
            Random rnd = new Random();
            for (int i = 0; i <= 14; i++) 
            {
                meowarray[i] = rnd.Next(-100, 100);            
            }
            for (int x = 0; x <= 14; x++)
            {
                InputMassList.Items.Add("mas[" + x + "]= " + meowarray[x]);
            }
        }

        private void proccesor()
        {
            int[] OutAr = new int[15];
            for (int i = 0; i < 15; i++)
            {
                if (meowarray[i] >=0)
                {
                    int sq = Convert.ToInt32(Math.Pow(meowarray[i], 2));
                    OutMassList.Items.Add("mas[" + i + "]= " + sq);
                }
                else
                {
                    OutMassList.Items.Add("mas[" + i + "]= " + 2 * meowarray[i]);
                }
            }
        }
    }
}
