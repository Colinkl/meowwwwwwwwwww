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
    public partial class z8 : Form
    {
        public z8()
        {
            InitializeComponent();
        }
        public int[,] a = new int[15, 15];
        private void z8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    a[i, j] = rand.Next(-100, 100);
            // Выводим матрицу в dataGridView1
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
        }
        
        private void processor()
        {
            dataGridView2.RowCount = 7;
            dataGridView2.ColumnCount = 7;
            int max = a[1,1];
            int ser = a[3, 3];
            int mx = 0;
            int my = 0;
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    if (a[i, i] > max)
                    {
                        max = a[i, i];
                        mx = i;
                        my = i;
                    }
                }
            for (int i = 6; i >= 0; i--)
                for (int j = 0; j < 7; j++)
                {
                    if (a[i, j] > max)
                    {
                            max = a[i, j];
                            mx = i;
                            my = j;
                     }
                }

            a[3, 3] = max;
            a[mx, my] = ser;                
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            processor();
        }
    }
}
