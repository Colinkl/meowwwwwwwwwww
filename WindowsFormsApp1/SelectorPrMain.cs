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
                    z4 ma = new z4();
                    ma.ShowDialog(); // показываем
                    break;
                case 4:
                    zz4 m4 = new zz4();
                    m4.ShowDialog();
                    break;
                case 5:
                    z5 m5 = new z5();
                    m5.ShowDialog();
                    break;
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           progg = Convert.ToInt16(listBox1.SelectedItem);

        }
    }
}