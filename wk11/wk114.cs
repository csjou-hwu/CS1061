using System;
using System.Diagnostics;
namespace 周重石Wk11
{
    class 類別1
    {
        public static void Main()
        {
            for (int i=0; i<3; i++)
            {
              Process 執行緒 = new Process();
              執行緒.StartInfo.UseShellExecute = false;
              執行緒.StartInfo.FileName = "wk113.exe";
              執行緒.Start();
            }
        }
    }
}