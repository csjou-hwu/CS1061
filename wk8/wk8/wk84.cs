using System;
using System.Windows.Forms;
using System.Drawing;
namespace 命名空間1
{
    public class 類別1
    {
        public static void Main()
        {
            //Console.WriteLine("周重石你好!");
            Application.Run(new 類別2());
        }
    }
    class 類別2 : Form
    {
        //小人類別[] 小人陣列 = new 小人類別[5];
        public 類別2()
        {
            this.Text = "092012";
            this.BackgroundImage = Image.FromFile("草原.jpg");
            this.Size = new Size(800, 600);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            for (int i = 0; i < 10; i++)
            {
                小人類別 小人 = new 小人類別();
                小人.Location = new Point(0, i * 40);
                this.Controls.Add(小人);
                小人.Click += new EventHandler(物件點到);
            }
            Timer 計時器 = new Timer();
            計時器.Interval = 400; // 0.3 秒
            計時器.Tick += new EventHandler(時間到方法);
            計時器.Start();
        }
        void 物件點到(Object O, EventArgs e)
        {
            ((小人類別)O).Visible = false;
        }
        void 時間到方法(Object O, EventArgs e)
        {
            int i=0;
            foreach (小人類別 小人物件 in this.Controls)
            {
                int x = 小人物件.Location.X + 20;
                if (x >= 640) x = 0;
                小人物件.Location = new Point(x, (i++) * 40);
            }
        }
    }
    class 小人類別 : PictureBox
    {
        public 小人類別()
        {
            this.Image = Image.FromFile("run1.gif");
            this.Size = new Size(137 / 5, 208 / 5);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Location = new Point(0, 540);
            //this.Click += new EventHandler(點到);
        }
        void 點到(Object O, EventArgs e)
        {
            this.Visible = false;
        }
        
    }
}