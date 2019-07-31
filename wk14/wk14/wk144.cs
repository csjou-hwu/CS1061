//---
using System;
using System.Windows.Forms;
using System.Drawing;
// mcs wk144.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk144.exe
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run( new 類別2());
        }
    }
    class 類別2 : Form
        {
            
            public 類別2()
            {
                T1 = new TextBox();
                T1.Location = new Point(0,0);
                this.Controls.Add(T1);
                T2 = new TextBox();
                T2.Location = new Point(0,50);
                this.Controls.Add(T2);
                T3 = new TextBox();
                T3.Location = new Point(0,100);
                this.Controls.Add(T3);
                T4 = new TextBox();
                T4.Location = new Point(0,150);
                this.Controls.Add(T4);
                Button B = new Button();
                B.Location = new Point(0,200);
                this.Controls.Add(B);
                B.Click += new EventHandler(計算);
            }
            TextBox T1, T2, T3, T4;
            private void 計算(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(T1.Text);
                double y = double.Parse(T3.Text);
                String op = T2.Text;
                double result = 0.0;
                switch (op)
                {
                    case "+": result = x + y; break;
                    case "-": result = x - y; break;
                    case "*": result = x * y; break;
                    case "/": result = x / y; break;
                    default: throw new Exception("出現錯誤!");
                }
                T4.Text = result.ToString();
            }
            catch
            {
                T4.Text = "錯誤";
            }
        }
        }
}