using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk13
{
    // http://www.dotnetspider.com/resources/15891-How-clip-portion-image-picturebox.aspx
    public partial class Form1 : Form
    {
        PictureBox pictureBox1 = new PictureBox();
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;
            this.Size = new Size(306, 333);
            var imgarray = new Image[9];
            var img = Image.FromFile("man.jpg");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var index = i * 3 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * 104, j * 104, 104, 104), GraphicsUnit.Pixel);
                    graphics.Dispose();
                    PictureBox P = new PictureBox();
                    P.Size = new Size(100, 100);
                    P.Left = i * 100;
                    P.Top = j * 100;

                    P.Image = imgarray[index];
                    P.Click += P_Click;
                    this.Controls.Add(P);

                }
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
