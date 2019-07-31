using System;
//-----
using System.Windows.Forms;
using System.Drawing;

namespace ＷinFormWk81
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Run (new Form1 ());
		}
	}
	class Form1:Form
	{
		Timer T = new Timer();
		Random R = new Random();
		Button [,] B = new Button[5,5];
		public Form1()
		{
			this.Size = new Size (300, 300);
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++) 
				{
					B[i,j] = new Button ();
					B[i,j].Width = 50;
					B[i,j].Height = 50;
					B[i,j].Location = new Point (i * 60, j * 60);
					B[i,j].Click += B_Click;
					this.Controls.Add (B[i,j]);
				}
			T.Interval = 100; // 1 sec
			T.Tick += T_Tick;
			T.Start ();
		}

		void T_Tick (object sender, EventArgs e)
		{
			int X = R.Next (5); int Y = R.Next (5);
			Color C = B [X, Y].BackColor;
			if (C == Color.Red)
				B [X, Y].BackColor = Color.Blue;
			else
				B [X, Y].BackColor = Color.Red;
		}

		void B_Click (object sender, EventArgs e)
		{
			Button B = (Button)sender;
			if (B.BackColor == Color.Red)
				B.BackColor = Color.Blue;
			else
				B.BackColor = Color.Red;

		}
	}
}
