using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System;
using System.Windows.Forms;
using System.Drawing;
// mcs wk132.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk132.exe
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run(new 類別2());
        }
    }
    class 類別2 : Form
    {
        int NN, NN2;
        public 類別2()
        {
            NN = 5;
            NN2 = NN * NN;
            圖片盒 = new PictureBox[NN2];
            int W = 400, H = 509;
            int Ws = W / NN;
            int Hs = H / NN;
            this.Size = new Size(W+6, H+33);
            var imgarray = new Image[NN2];
            var img = Image.FromFile("ex2.jpg");
            int[] index = new int[NN2];
            for (int i = 0; i < NN; i++)
            {
                for (int j = 0; j < NN; j++)
                {
                    index[i * NN + j] = i * NN + j;
                    imgarray[index[i * NN + j]] = new Bitmap(Ws, Hs);
                    var graphics = Graphics.FromImage(imgarray[index[i * NN + j]]);
                    graphics.DrawImage(img, new Rectangle(0, 0, Ws, Hs), new Rectangle(i * Ws, j * Hs, Ws, Hs), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            //Random 亂數 = new Random();
            index = Shuffle<int>(index);
            for (int i = 0; i < NN; i++)
                for (int j = 0; j < NN; j++)
                {

                    圖片盒[index[i * NN + j]] = new PictureBox();
                    圖片盒[index[i * NN + j]].Image = imgarray[index[i * NN + j]];
                    圖片盒[index[i * NN + j]].Size = new Size(Ws, Hs);
                    圖片盒[index[i * NN + j]].Location = new Point(Ws * i, Hs * j);
                    this.Controls.Add(圖片盒[index[i * NN + j]]);
                    圖片盒[index[i * NN + j]].Click += new EventHandler(按一下方法);
                }
        }
        bool 第一次 = true;
        PictureBox[] 圖片盒; // = new PictureBox[NN2];
        int 暫存圖片盒位置 = 0;
        private void 按一下方法(object 觸發物件, EventArgs 事件參數)
        {
            if (第一次)
            {
                第一次 = false;
                暫存圖片盒位置 = Array.IndexOf(圖片盒, (PictureBox)觸發物件);
                this.Text = 暫存圖片盒位置.ToString();
            }
            else
            {
                第一次 = true;
                int 目前圖片盒位置 = Array.IndexOf(圖片盒, (PictureBox)觸發物件);
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