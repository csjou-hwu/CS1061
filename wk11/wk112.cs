using System;
using System.Windows.Forms;
using System.Drawing;
namespace 周重石wk11
{
    class 類別1
    {
        public static void Main()
        {
            Application.Run(new 類別2());
        }
    }
    class 類別2 : Form
    {
        Button [,] 按鈕陣列 = new Button[3,3];
        public 類別2()
        {
            this.Size = new Size(306, 333);
            for (int i=0; i<3; i++)
                for (int j=0; j<3; j++)
                {
                    按鈕陣列[i,j] = new Button();
                    按鈕陣列[i,j].Size = new Size(100,100);
                    按鈕陣列[i,j].Font = new Font(按鈕陣列[i,j].Font.Name, 36.0F, 
                                        按鈕陣列[i,j].Font.Style, 按鈕陣列[i,j].Font.Unit);
                    //按鈕陣列[i,j].Text = "";
                    按鈕陣列[i,j].Location = new Point(i*100, j*100);
                    按鈕陣列[i,j].Click += new EventHandler(按按鈕方法);
                    this.Controls.Add(按鈕陣列[i,j]);
                }
        }
        bool 圈 = true;
        private void 按按鈕方法(Object 觸發物件, EventArgs 事件參數)
        {
            Button 觸發按鈕 = (Button)觸發物件;
            if (觸發按鈕.Text == "")
            {
                if (圈)
                {
                    觸發按鈕.Text = "O";
                    圈 = false;
                }
                else
                {
                    觸發按鈕.Text = "X";
                    圈 = true;
                }
            }
        }
    }
}