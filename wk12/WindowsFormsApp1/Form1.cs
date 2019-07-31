using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(512 + 6, 512 + 33);
            PictureBox P = new PictureBox();
            P.Size = new Size(512*2, 512*2);
            P.ImageLocation = "ex1.png";
            // 1.
            //P.Left = 0;
            //P.Top = 0;
            // 2.
            //P.Left = -512;
            //P.Top = 0;
            // 3.
            P.Left = 0;
            P.Top = -512;
            P.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(P);
        }
    }
}
