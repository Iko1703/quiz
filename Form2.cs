using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNGASU_TEST
{
    
    public partial class Form2 : Form
    {
        int[] poradok = new int[10];
        string [] papka = new string[10];
        int number1 = 0;

        public Form2()
        {
            InitializeComponent();
            TakePhoto take = new TakePhoto();
            papka = take.Take();
            Logic();
            
        }
        
        public void Logic()
        {
            for (int i = 0; i < poradok.Length; i++)
            {
                poradok[i] = i;
            }
            Random.Shared.Shuffle(poradok);
            
            vopros(poradok[number1]);
        }
        public void vopros(int num)
        {
            label2.Text = number1+1 + "/10";
            string name = Convert.ToString(papka[num]);
            Bitmap MyImage;
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\" + name + ".jpg");
            pictureBox1.Image = (Image)MyImage;
            label1.Text = name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (number1 != poradok.Length - 1)
            {
                number1++;
                
                vopros(poradok[number1]);

            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                number1--;
                vopros(poradok[number1]);

            }
        }
    }
    public class TakePhoto()
    {
        string[] papka = new string[10];
        public string[] Take()
        {
            var dir = new DirectoryInfo("C:\\Users\\ванек\\Desktop\\LABTESTNEW");
            int cells = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                papka[cells++] = Path.GetFileNameWithoutExtension(file.FullName);
            }
            return papka;
        }
    }
}
