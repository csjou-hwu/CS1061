using System;
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
            Application.Run( new 類別2());
        }
    }
    class 類別2 : Form
    {
        public 類別2()
        {
            this.Size = new Size(320,345);
            var imgarray = new Image[9];
            var img = Image.FromFile("wk131.png");
            for( int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    var index = i*3+j;
                    imgarray[index] = new Bitmap(104,104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage( img, new Rectangle(0,0,104,104), new Rectangle(i*104, j*104,104,104), GraphicsUnit.Pixel);
                    graphics.Dispose();
                    PictureBox 圖片盒 = new PictureBox();
                    圖片盒.Image = imgarray[index];
                    圖片盒.Size = new Size(104,104);
                    圖片盒.Location = new Point(104*i, 104*j);
                    this.Controls.Add(圖片盒);
                }
            }
            
        }
    }
}