// wk33.cs
// mcs wk33.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk33.exe
using System;
using System.Windows.Forms;
using System.Drawing;
namespace  命名空間1
{
	class 類別1
	{
		public static void Main()
		{
		表單類別 表單物件 = new 表單類別();
		PictureBox 圖片物件 = new PictureBox();
		圖片物件.SizeMode = PictureBoxSizeMode.StretchImage ;
		圖片物件.Image = Image.FromFile("Stickman.gif");
		圖片物件.Size = new Size(500,500);
		表單物件.Controls.Add(圖片物件);
		Application.Run(表單物件);
		}
	}
	class 表單類別 : Form  // : 繼承
	{
		public 表單類別() // 建構元方法
		{
			this.BackgroundImage = Image.FromFile("stickman.gif");
			this.Size = new Size(500,500);
		}
	}
}