using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NNGASU_TEST
{
    public partial class Form3 : Form
    {

        public int[,] variants = new int[4, 4];
        int number1 = 0;
        string[] tr = new string[4];
        bool[] Que = new bool[] { true, true, true, true };
        int count = 0;
        float pos = 0;
        string[] papka = new string[10];
        int[] poradokForAns = new int[4];
        
        int countQue = 4;
        public Form3()
        {
            InitializeComponent();
            TakePhoto takePhoto = new TakePhoto();
            papka = takePhoto.Take();
            button7.Visible = false;
            button8.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
            Logic();
            vopros();
        }

        public void Logic()
        {
            for (int i = 0; i < 4; i++)
            {
                int[] arr = new int[10];
                for (int j = 0; j < papka.Length; j++)
                {
                    arr[j] = j;
                }
                Random.Shared.Shuffle(arr);
                for (int j = 0; j < 4; j++)
                {
                    variants[i, j] = arr[j];
                }
            }
            
            for (int j = 0; j < 4; j++)
            {
                poradokForAns[j] = j;
            }
            Random.Shared.Shuffle(poradokForAns);
            for (int i = 0;i<4;i++)
            {
                int x = variants[i, i];
                for (int j =0 ; j < 4; j++)
                {
                    if (x == variants[j,j] && variants[i, j]!= variants[j, j])
                    {
                        Logic(); return;
                    }
                }
            }
        }
        public void vopros()
        {
            label1.Text = number1 + 1 + "/4";
            string name = papka[variants[number1, number1]];
            Bitmap MyImage;
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\" + name + ".jpg");
            pictureBox1.Image = (Image)MyImage;
            for (int i = 0; i < tr.Length;i++)
            {
                if (i == number1)
                {
                    tr[i] = name;
                    if (Que[i] != false)
                    {
                        Que[i] = true;
                    }
                    
                }
            }
            button1.Text = papka[variants[number1, poradokForAns[2]]];
            button4.Text = papka[variants[number1, poradokForAns[1]]];
            button5.Text = papka[variants[number1, poradokForAns[0]]];
            button6.Text = papka[variants[number1, poradokForAns[3]]];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (number1 != 4 - 1)
            {
                number1++;
                pereh();
                vopros();

            }
            if (number1 == 4 - 1)
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
            if (number1 != 0)
            {
                number1--;
                pereh();
                vopros();
            }

            button7.Visible = false;


        }
        public void pereh()
        {
            bool kak = true;
            
            for (int i = 0; i < tr.Length; i++)
            {
                if (i == number1)
                {
                    kak = Que[i];
                }
            }
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
            string real = "";
            pos++;
            label4.Text = Convert.ToString((pos / countQue) * 100) + "%";
            for (int i = 0; i < tr.Length; i++)
            {
                if (i == number1)
                {
                    real = tr[i]; Que[i] = false; 
                }
            }
            if (button.Text == real)
            {
                button.BackColor = Color.Green;
                count++;
                
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
            label3.Text = "Ваш результат: " + count + "/4";
            pictureBox2.Visible = true;
            Bitmap MyImage;
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\дед инсульт.jpg");
            pictureBox2.Image = (Image)MyImage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
