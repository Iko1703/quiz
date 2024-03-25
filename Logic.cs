using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNGASU_TEST
{
    internal class Logic
    {
        public int number = 0;
        public static int rangeOfPhoto = new DirectoryInfo("C:\\Users\\ванек\\Desktop\\LABTESTNEW").GetFiles().Length;
        public string[] papka = new string[rangeOfPhoto];
        public int[] poradok = new int[rangeOfPhoto];
        public string nowName = "";
        public Bitmap MyImage;
        //form 3
        public int[,] variants = new int[4, 4];
        public string[] tr = new string[4];
        public bool[] Que = new bool[] { true, true, true, true };
        public int count = 0;
        public float pos = 0;
        public int[] poradokForAns = new int[4];
        public int countQue = 4;
        public int Range()
        {
            return rangeOfPhoto;
        }
        public void StartOfQue()
        {
            Start();
            for (int i = 0; i < 4; i++)
            {
                int[] arr = new int[papka.Length];
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
            for (int i = 0; i < 4; i++)
            {
                int x = variants[i, i];
                for (int j = 0; j < 4; j++)
                {
                    if (x == variants[j, j] && variants[i, j] != variants[j, j])
                    {
                        StartOfQue(); return;
                    }
                }
            }
            voprosForQue(number);
        }
        public void voprosForQue(int num)
        {
            nowName = papka[variants[number, number]];
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\" + nowName + ".jpg");
            for (int i = 0; i < tr.Length; i++)
            {
                if (i == number)
                {
                    tr[i] = nowName;
                    if (Que[i] != false)
                    {
                        Que[i] = true;
                    }
                }
            }
        }
        public string RealOrNot()
        {
           
            string res = null;
            for (int i = 0; i < tr.Length; i++)
            {
                if (i == number)
                {
                    Que[i] = false;
                    res = tr[i]; 
                }
            }
            return res;
        }
        public bool per()
        {
            bool kak = true;
            for (int i = 0; i < tr.Length; i++)
            {
                if (i == number)
                {
                    kak = Que[i];
                }
            }
            return kak;
        }
        public void Start()
        {
            var dir = new DirectoryInfo("C:\\Users\\ванек\\Desktop\\LABTESTNEW");
            int cells = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                papka[cells++] = Path.GetFileNameWithoutExtension(file.FullName);
            }
            for (int i = 0; i < poradok.Length; i++)
            {
                poradok[i] = i;
            }
            Random.Shared.Shuffle(poradok);
            
        }
        public void vopros(int num)
        {
            nowName = Convert.ToString(papka[num]);
            MyImage = new Bitmap("C:\\Users\\ванек\\Desktop\\LABTESTNEW\\" + nowName + ".jpg");
        }
        public bool NextSlide(int num)
        {
            if (number != poradok.Length - 1)
            {
                number++;
                vopros(poradok[number]);
                return true;
            }
           
            return false;
        }
        public bool FirstSlide(int num)
        {
            if (number != 0)
            {
                number--;
                vopros(poradok[number]);
                return true;
            }
            return false;
            
        }
    }
}
