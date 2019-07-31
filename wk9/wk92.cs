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
                小人類別 小人 = new 小人類別();
                小人.Location = new Point(250, 300);
                this.Controls.Add(小人);   
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
        }
    }
}