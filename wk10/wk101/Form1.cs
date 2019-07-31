using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fs = button1.Font.Size * 1.1;
            button1.Font = new Font(button1.Font.FontFamily, (float)fs, button1.Font.Style, button1.Font.Unit);
        }
    }
}
