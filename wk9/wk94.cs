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
            this.Size = new Size(800, 600);
            for (int i=0; i<2; i++)
            for (int j=0; j<2; j++)
            {
                小人類別 小人 = new 小人類別();
                小人.Location = new Point(i*160, 80+ j*110);
                this.Controls.Add(小人);
            }
            /*
            Label X平移按鈕 = new Label();
            X平移按鈕.Text = "SHIFT X";
            X平移按鈕.Location = new Point(300,0);
            X平移按鈕.Size = new Size(200,40);
            X平移按鈕.Click += new EventHandler(平移小人X);  
            this.Controls.Add(X平移按鈕);
            Label Y平移按鈕 = new Label();
            Y平移按鈕.Text = "SHIFT Y";
            Y平移按鈕.Location = new Point(300,50);
            Y平移按鈕.Size = new Size(200,40);
            Y平移按鈕.Click += new EventHandler(平移小人Y);  
            this.Controls.Add(Y平移按鈕);
            */
            this.KeyPress += new KeyPressEventHandler(平移小人X);
            this.KeyPress += new KeyPressEventHandler(平移小人Y);
        }
        void 平移小人X(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'x')
            {
                foreach (小人類別 小人物件 in this.Controls)
                {               
                    小人物件.平移物件方法();
                }
            }
            else if (e.KeyChar == 'y')
            {
                foreach(小人類別 小人 in this.Controls )
                {
                    小人類別.平移類別方法(小人);
                }
            }
        }
        void 平移小人Y(Object O, EventArgs e)
        {
            
        }
        

    }
    class 小人類別 : PictureBox
    {
        public 小人類別()
        {
            this.Image = Image.FromFile("run1.gif");
            this.Size = new Size(150, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.Location = new Point(0, 0);
            this.Click += new EventHandler(Click事件方法);
        }
        void Click事件方法(Object O, EventArgs e)
        {
            //平移類別方法();
        }
        public void 平移物件方法()
        {
            this.Location = new Point(this.Location.X+10, this.Location.Y);
        }
        public static void 平移類別方法(Object O)
        {
            ((小人類別)O).Location = new Point(((小人類別)O).Location.X, ((小人類別)O).Location.Y+10);
        }
    }
}