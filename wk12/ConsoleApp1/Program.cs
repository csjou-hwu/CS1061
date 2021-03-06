﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    using System;
    using System.IO;
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
            string libDirectory;
            if (IntPtr.Size == 4)
            {
                // Use 32 bits library
                libDirectory = Path.Combine(Environment.CurrentDirectory, "libvlc_x86");
            }
            else
            {
                // Use 64 bits library
                libDirectory = Path.Combine(Environment.CurrentDirectory, "libvlc_x64");
            }

            var options = new string[]
            {
                // VLC options can be given here. Please refer to the VLC command line documentation.
            };

            var mediaPlayer = new Vlc.DotNet.Core.VlcMediaPlayer (new DirectoryInfo(@"E:\Course1061\docker1061\wk12\vlc-2.2.8-win32\vlc-2.2.8\sdk\lib"));

            var mediaOptions = new string[]
            {
                ":sout=#file{dst="+Path.Combine(Environment.CurrentDirectory, "output.mov")+"}",
                ":sout-keep"
            };

            mediaPlayer.SetMedia(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_h264.mov"), mediaOptions);

            bool playFinished = false;
            mediaPlayer.PositionChanged += (sender, e) =>
            {
                Console.Write("\r" + Math.Floor(e.NewPosition * 100) + "%");
            };

            mediaPlayer.EncounteredError += (sender, e) =>
            {
                Console.Error.Write("An error occurred");
                playFinished = true;
            };

            mediaPlayer.EndReached += (sender, e) => {
                playFinished = true;
            };

            mediaPlayer.Play();

            // Ugly, sorry, that's just an example...
            while (!playFinished)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
        }
    }
}
