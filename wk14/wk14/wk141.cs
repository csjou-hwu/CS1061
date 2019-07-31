//---
using System;
using System.Windows.Forms;
using System.Drawing;
// mcs wk141.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk141.exe
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
this.Size = new Size(320,345);
var imgarray = new Image[9];
var img = Image.FromFile("wk141.png");
int [] index = new int[9];
for( int i = 0; i < 3; i++)
{
for( int j = 0; j < 3; j++)
{
index[i*3+j] = i*3+j;
imgarray[index[i*3+j]] = new Bitmap(104,104);
var graphics = Graphics.FromImage(imgarray[index[i*3+j]]);
graphics.DrawImage( img, new Rectangle(0,0,104,104), new Rectangle(i*104, j*104,104,104), GraphicsUnit.Pixel);
graphics.Dispose();
}
}
//Random 亂數 = new Random();
index = Shuffle<int>(index);
for( int i = 0; i < 3; i++)
for( int j = 0; j < 3; j++)
{

圖片盒[index[i*3+j]] = new PictureBox();
圖片盒[index[i*3+j]].Image = imgarray[index[i*3+j]];
圖片盒[index[i*3+j]].Size = new Size(104,104);
圖片盒[index[i*3+j]].Location = new Point(104*i, 104*j);
this.Controls.Add(圖片盒[index[i*3+j]]);
圖片盒[index[i*3+j]].Click += new EventHandler(按一下方法);
}
}
bool 第一次 = true;
PictureBox [] 圖片盒 = new PictureBox[9];
int 暫存圖片盒位置 = 0;
private void 按一下方法(object 觸發物件, EventArgs 事件參數)
{
if (第一次)
{
第一次 = false;
暫存圖片盒位置 = Array.IndexOf(圖片盒,(PictureBox)觸發物件);
this.Text = 暫存圖片盒位置.ToString();
}
else
{
第一次 = true;
int 目前圖片盒位置 = Array.IndexOf(圖片盒,(PictureBox)觸發物件);
this.Text += "<->" + 目前圖片盒位置.ToString();
PictureBox 暫存圖片盒 = new PictureBox();
暫存圖片盒.Image = 圖片盒[暫存圖片盒位置].Image;
圖片盒[暫存圖片盒位置].Image = 圖片盒[目前圖片盒位置].Image;
圖片盒[目前圖片盒位置].Image = 暫存圖片盒.Image;

}
}
public T[] Shuffle<T>(T[] array)
{
Random random = new Random();
for (int i = array.Length; i > 1; i--)
{
// Pick random element to swap.
int j = random.Next(i); // 0 <= j <= i-1
// Swap.
T tmp = array[j];
array[j] = array[i - 1];
array[i - 1] = tmp;
}
return array;
}
}
}