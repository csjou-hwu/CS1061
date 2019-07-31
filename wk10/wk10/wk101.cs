using System;
using System.Windows.Forms;
using System.Drawing;
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            //Application.Run( new 類別2());
            類別2 表單物件 = new 類別2();
            //Button 按鈕物件 = new Button();
            按鈕物件 = new Button();
            按鈕物件.Click += new EventHandler(按一下方法);
            表單物件.Controls.Add(按鈕物件);
            Application.Run(表單物件);
        }
        // 2. 全域變數
        static Button 按鈕物件;
        static void 按一下方法(Object 物件, EventArgs 參數)
        {
            // 1 強制轉型
            //((Button)物件).Text = "O";
            按鈕物件.Text = "X";
        }
    }
    class 類別2 : Form
    {
        public 類別2()
        {
            //Button 按鈕物件 = new Button();
            //this.Controls.Add(按鈕物件);
        }
    }
}