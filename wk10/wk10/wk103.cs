using System;
using System.Windows.Forms;
using System.Drawing;
namespace Name1
{
    class Name1
    {
        public static void Main()
        {
            Application.Run(new Name2());
        }
    }
    class Name2 : Form
    {
        public Name2()
        {
            Button B = new Button();
            B.Size = new Size(100,100);
            B.Click += new EventHandler(方法1);
            B.Text = "O";
            this.Controls.Add(B);
        }
        void 方法1(Object 觸發物件, EventArgs 觸發參數)
        {
            Button 按鈕物件 = (Button)觸發物件;
            float currentSize = 按鈕物件.Font.Size;
            currentSize += 2.0f;
            this.Text = currentSize.ToString();
            按鈕物件.Font = new Font(按鈕物件.Font.Name, currentSize, 
                按鈕物件.Font.Style, 按鈕物件.Font.Unit);
        }
    }
}