using System;
using System.Windows.Forms;
using System.Drawing;
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run(new 表單類別());
        }
    }
    class 表單類別 : Form
    {
        小人類別 [] 小人陣列 = new 小人類別[5];
        public 表單類別()
        {
                this.Text = "092012";
                this.BackgroundImage = Image.FromFile("草原.jpg");
                this.Size = new Size(800,600);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                for (int i=0; i<5; i++)
                {
                    小人陣列[i] = new 小人類別();
                    小人陣列[i].Location = new Point(0, i*80);
                    this.Controls.Add(小人陣列[i]);
                }
                Timer 計時器 = new Timer();
                計時器.Interval = 300; // 0.3 秒
                計時器.Tick += new EventHandler(時間到方法);
                計時器.Start();
        }
        void 時間到方法(Object O, EventArgs e)
        {
            for (int i=0; i<5; i++)
                {
                    int x = 小人陣列[i].Location.X + 20;
                    if (x >= 640) x=0;
                    小人陣列[i].Location = new Point(x, i*80);
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
        }
    }
    
}