using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//14. Написать программу с кнопкой и тремя полями ввода.При на-
//жатии на кнопку программа анализирует содержимое первого поля
//и динамически порождает элемент управления.Если в первом поле вво-
//да содержится буква «К», то на форму добавляется кнопка, если «П» –
//поле ввода, если «М» – метка.Во втором и третьем поле ввода содержат-
//ся координаты левого верхнего угла будущего элемента управления.
namespace WindowsFormsApp1
{
    public partial class z5 : Form
    {
        public z5()
        {
            InitializeComponent();
        }

        private void z5_Load(object sender, EventArgs e)
        {

        }
        private void newbutton(int cx,int cy)
        {
            Button bbb = new Button();
            bbb.Parent = this;
            bbb.Location = new Point(cx, cy);
            bbb.Size = new Size(100, 100);
            bbb.Text = "owo";

        }

        private void newbox(int cx,int cy)
        {
            TextBox ttt = new TextBox();
            ttt.Parent = this;
            ttt.Location = new Point(cx, cy);
            ttt.Size = new Size(30, 100);
            ttt.Text = "meow";
        }
        private void newmet(int cx,int cy)
        {
             Label lll = new Label();
            lll.Parent = this;
            lll.Location = new Point(cx, cy);
            lll.Size = new Size(300, 100);
            lll.Text = "(₌චᆽච₌)";
        }

        private void xbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void creator_Click(object sender, EventArgs e)
        {
            try
            {
                int cx = Convert.ToInt32(xbox.Text);
                int cy = Convert.ToInt32(ybox.Text);
                string typeN = typebox.Text;
                mastercreator(typeN, cx, cy);
            }
            catch (Exception)
            {
                xbox.Text = "0";
                typebox.Text = "ERROR";
                ybox.Text = "0";                
            }
            
        }

        private void mastercreator(string typeNewObj,int cx, int cy)
        {
            switch (typeNewObj)
            {
                case "К":
                    newbutton(cx, cy);
                    break;
                case "П":
                    newbox(cx,cy);
                    break;
                case "М":
                    newmet(cx, cy);
                    break;
                default:
                    xbox.Text = "0";
                    typebox.Text = "ERROR";
                    ybox.Text = "0";
                    break;
            }
               
        }
        
    }
}
