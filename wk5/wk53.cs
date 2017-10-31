// wk53.cs
// mcs wk53.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk53.exe
using System;
using System.Windows.Forms;
using System.Drawing;
namespace 命名空間1
{
	class 類別1
	{
		public static void Main()
		{
			//Form  表單物件 = new Form();
			//表單物件.Text = "092012";
			//表單物件.BackColor = Color.Red;
			Application.Run(new 表單類別());
		}
	}
	class 表單類別 : Form
	{
		public 表單類別()
		{
			this.Text = "092012";
			//this.BackColor = Color.Pink;
			this.BackgroundImage = Image.FromFile("草原.jpg");
			this.Size = new Size(800,600);
			this.BackgroundImageLayout = ImageLayout.Stretch;
			for (int i=0; i<10; i++)
			{
				小人類別 小人物件 = new 小人類別();
				小人物件.Location = new Point(i*50, 540 - i*50);		
				this.Controls.Add(小人物件);
			}
		}		
	}
	class 小人類別 : PictureBox
	{
		public 小人類別()
		{
			this.Image = Image.FromFile("run1.gif");
			this.Size = new Size(137/5,208/5);
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.BackColor = Color.Transparent;
			this.Location = new Point(0, 540);
			Timer 計時器物件 = new Timer();  // 1. 計時器物件
			計時器物件.Tick += new EventHandler(時間到方法);  // 2. 事件方法
			計時器物件.Interval = 100; // 3. 0.1 秒
			計時器物件.Start();			
		}
		void 時間到方法(Object O, EventArgs e)
		{
			int x = this.Location.X + 10;
			if ( x >= 640) x = 0;
			this.Location = new Point(x, this.Location.Y);
		}
	}
}