// wk51.cs
// mcs wk51.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk51.exe
using System;
using System.Windows.Forms;
using System.Drawing;
namespace 命名空間1
{
	class 類別1
	{
		public static void Main()
		{
			Form  表單物件 = new Form();
			表單物件.Text = "092012";
			表單物件.BackColor = Color.Red;
			Application.Run(表單物件);
		}
	}
}