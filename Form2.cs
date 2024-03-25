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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NNGASU_TEST
{
    
    public partial class Form2 : Form
    {
        static Logic take = new Logic();
        public Form2()
        {
            InitializeComponent();
            take = new Logic();
            take.Start();
            take.vopros(take.poradok[take.number]);
            NewSlide();
        }
        private void NewSlide()
        {
            label2.Text = take.number + 1 +  $"/{take.papka.Length}";
            pictureBox1.Image = (Image)take.MyImage;
            label1.Text = take.nowName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (take.NextSlide(take.number))
            {
                NewSlide();
            }
            else
            {
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (take.FirstSlide(take.number))
            {
                NewSlide();
            }
        }
    }
    
}
