// wk102.cs
// mcs wk102.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk102.exe
using System;
using System.Windows.Forms;
using System.Drawing;
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
        bool 圈 = true;
        public 類別2()
        {
            this.Size = new Size(306,333);
            for (int i=0; i<3; i++)
              for (int j=0; j<3; j++)
              {
                Button 按鈕物件 = new Button();
                //按鈕物件.Text = "";
                按鈕物件.Size = new Size(100,100);
                按鈕物件.Location = new Point(i*100, j*100);
                按鈕物件.Click += new EventHandler(按一下方法);
                this.Controls.Add(按鈕物件);
              }
        }
        void 按一下方法(Object 物件, EventArgs 參數)
        {
            
            if( ((Button)物件).Text == "") 
            {
                if (圈)
                {
                   ((Button)物件).Text = "O"; 
                   圈 = false;
                }
                else
                {
                    ((Button)物件).Text = "X"; 
                    圈 = true;
                }
            }
            
        }
    }
}