// wk32.cs
// mcs wk32.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk32.exe
using System;
using System.Windows.Forms;
using System.Drawing;
namespace  命名空間1
{
	class 類別1
	{
		public static void Main()
		{
Application.Run(new 表單類別());
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