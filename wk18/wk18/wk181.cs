using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using System;
namespace N1
{
	class C1
	{
	    public static void Main()
		{
            ImageViewer viewer = new ImageViewer(); //create an image viewer
            Capture capture = new Capture(); //create a camera captue
            Application.Idle += new EventHandler(delegate(object sender, EventArgs e)
            {  //run this until application closed (close button click on image viewer)
                viewer.Image = capture.QueryFrame(); //draw the image obtained from camera
            });
            viewer.ShowDialog(); //show the image viewer
		}
	}
}

// download https://sourceforge.net/projects/emgucv/
// libemgucv-osx-x86-2.4.9.1839.zip
// mcs -r:EMGU.CV.DLL -r:EMGU.CV.UI.dll -r:ZedGraph.DLL -r:System.Windows.Forms.DLL -r:System.Drawing.DLL wk181.cs -r:EMGU.UTIL.DLL
