# CS1061 <br/>
C# course examples <br/>
<hr/>
git update command (CMD) <br/>
git add . <br/>
git commit -m “write something” <br/>
git push -u origin master <br/>
<h3>wk1 </h3>
1. Mac 工作環境介紹 <br/>
2. cmd+shift+3 <br/>
3. mcs xxx.cs <br/>
4. mono xxx.exe <br/>
5. C# Hello world <br/>
<h3>wk2 </h3>
1. C# 基本架構 (namespace/class/method)<br/>
2. C# 4種方法  (Main/建構元方法/類別方法/物件方法)<br/>
3. 使用外部類別(Form)<br/>
mcs xxx.cs -r:System.Windows.Forms.DLL<br/>
mono xxx.exe<br/>
<h3>wk3</h3>
1. 繼承  class 表單類別 : Form<br/>
2. 表單背景:this.BackgroundImage = Image.FromFile("stickman.gif");<br/>
3. 圖片盒 PictureBox <br/>
4. 圖片模式：圖片物件.SizeMode = PictureBoxSizeMode.StretchImage ;<br/>
<h3>wk5</h3>
1. Form 控制項<br/>
mcs xxx.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL<br/>
mono xxx.exe<br/>
2. PictureBox 控制項屬性 / for (int i=0; i<N; i++)<br/>
Timer 計時器物件 = new Timer();  // 1. 計時器物件<br/>
計時器物件.Tick += new EventHandler(時間到方法);  // 2. 事件方法<br/>
計時器物件.Interval = 100; // 3. 0.1 秒<br/>
計時器物件.Start();<br/>
... <br/>
void 時間到方法(Object O, EventArgs e)<br/>
{...}<br/>
