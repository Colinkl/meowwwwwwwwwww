﻿using System;
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
    public partial class selector_app : Form
    {
        public selector_app()
        {
            InitializeComponent();
        }

        private int progg;
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (progg)
            {
                case 1:
                    meow me =  new meow();
                    me.ShowDialog(); // показываем
                    break;
                case 2:
                    Form3 mi = new Form3();
                    mi.ShowDialog(); // показываем
                    break;
                case 3:
                    meow ma = new meow();
                    ma.ShowDialog(); // показываем
                    break;

            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           progg = Convert.ToInt16(listBox1.SelectedItem);

        }
    }
}
