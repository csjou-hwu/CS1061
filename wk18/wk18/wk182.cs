//---
using System;
using System.Windows.Forms;
using System.Drawing;
// mcs wk142.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk142.exe
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run( new 類別2());
        }
    }
    class 類別2 : Form
        {
            bool 第一次 = true;
            PictureBox [] 圖片盒;
            int 暫存圖片盒位置 = 0;
            int W = 400;
            int H = 509;
            int MM = 5;
            int NN = 5;
            public 類別2()
            {
                圖片盒 = new PictureBox[MM*NN];
                this.Size = new Size(W+6,H+33);
                var imgarray = new Image[MM*NN];
                var img = Image.FromFile("wk182.png");
                int [] index = new int[MM*NN];
                for( int i = 0; i < MM; i++)
                {
                    for( int j = 0; j < NN; j++)
                    {
                        index[i*NN+j] = i*NN+j;
                        imgarray[index[i*NN+j]] = new Bitmap(W/MM,H/NN);
                        var graphics = Graphics.FromImage(imgarray[index[i*NN+j]]);
                        graphics.DrawImage( img, new Rectangle(0,0,W/MM,H/NN), new Rectangle(i*W/MM, j*H/NN,W/MM,H/NN), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }
                //Random 亂數 = new Random();
                index = Shuffle<int>(index);
                for( int i = 0; i < MM; i++)
                    for( int j = 0; j < NN; j++)
                    {
                    圖片盒[index[i*NN+j]] = new PictureBox();
                    圖片盒[index[i*NN+j]].Image = imgarray[index[i*NN+j]];
                    圖片盒[index[i*NN+j]].Size = new Size(W/MM,H/NN);
                    圖片盒[index[i*NN+j]].Location = new Point(W/MM*i, H/NN*j);
                    this.Controls.Add(圖片盒[index[i*NN+j]]);
                    圖片盒[index[i*NN+j]].Click += new EventHandler(按一下方法);
                    }
            }
            private void 按一下方法(object 觸發物件, EventArgs 事件參數)
            {
                if (第一次)
                {
                    第一次 = false;
                    暫存圖片盒位置 = Array.IndexOf(圖片盒,(PictureBox)觸發物件);
                    this.Text = 暫存圖片盒位置.ToString();
                }
                else
                {
                    第一次 = true;
                    int 目前圖片盒位置 = Array.IndexOf(圖片盒,(PictureBox)觸發物件);
                    this.Text += "<->" + 目前圖片盒位置.ToString();
                    PictureBox 暫存圖片盒 = new PictureBox();
                    暫存圖片盒.Image = 圖片盒[暫存圖片盒位置].Image;
                    圖片盒[暫存圖片盒位置].Image = 圖片盒[目前圖片盒位置].Image;
                    圖片盒[目前圖片盒位置].Image = 暫存圖片盒.Image;
                 }
            }
            public T[] Shuffle<T>(T[] array)
            {
                Random random = new Random();
                for (int i = array.Length; i > 1; i--)
                {
                    // Pick random element to swap.
                    int j = random.Next(i); // 0 <= j <= i-1
                    // Swap.
                    T tmp = array[j];
                    array[j] = array[i - 1];
                    array[i - 1] = tmp;
                }
                return array;
            }
        }
}