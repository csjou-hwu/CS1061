using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
//mcs wk121.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
namespace 周重石wk12
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run(new 類別2());
        }
    }
    class 類別2:Form
    {
        PictureBox 圖片盒;
        public 類別2()
        {
            圖片盒 = new PictureBox();
            圖片盒.ImageLocation = "wk121.png";
            圖片盒.Size = new Size(512*2,512*2);
            圖片盒.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(512+6, 512+30+3);
            圖片盒.Left = 0;
            圖片盒.Top = 0;
            this.Controls.Add(圖片盒);
            Process.Start("Say", "你覺得世上最痛苦的事是什麼？");
            Process.Start("Say", "早上上程式語言的課．");
        }
    }
}