using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NNGASU_TEST
{
    public partial class Form3 : Form
    {
        static Logic take = new Logic();
        public Form3()
        {
            InitializeComponent();
            take = new Logic();
            
            take.StartOfQue();
            NewSlide();
            button7.Visible = false;
            button8.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
        }
        private void NewSlide()
        {
            label1.Text = take.number + 1 + "/4";
            pictureBox1.Image = take.MyImage;
            button1.Text = take.papka[take.variants[take.number, take.poradokForAns[2]]];
            button4.Text = take.papka[take.variants[take.number, take.poradokForAns[1]]];
            button5.Text = take.papka[take.variants[take.number, take.poradokForAns[0]]];
            button6.Text = take.papka[take.variants[take.number, take.poradokForAns[3]]];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (take.number != 4 - 1)
            { 
                take.number++;               
                take.voprosForQue(take.number);
                pereh();
                NewSlide();
            }
            if (take.number == 4 - 1)
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (take.number != 0)
            {
                take.number--;
                take.voprosForQue(take.number);
                pereh();
                NewSlide();
            }
            button7.Visible = false;
        }
        public void pereh()
        {
            bool kak = take.per();            
            if (!kak)
            {
                BlockBut();
            }
            else
            {
                UnBlockBut();
            }
            button1.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }
        public void BlockBut()
        {
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
        public void UnBlockBut()
        {
            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
        public void voite(Button button)
        {
            take.pos++;
            label4.Text = Convert.ToString((take.pos / take.countQue) * 100) + "%";
            string real = take.RealOrNot();
            if (button.Text == real)
            {
                button.BackColor = Color.Green;
                take.count++;
            }
            else
            {
                button.BackColor = Color.Red;
            }
            BlockBut();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            voite(button1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            voite(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            voite(button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            voite(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label3.Text = "Ваш результат: " + take.count + "/4";
            pictureBox2.Visible = true;
            Bitmap MyImage;
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\дед инсульт.jpg");
            pictureBox2.Image = MyImage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
