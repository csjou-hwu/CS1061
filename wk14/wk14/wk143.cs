using System;

class 類別1
{
    public static void Main(string[] args)
    {
        int a = 3; int b = 0;
        bool 不結束 = true;
        Console.Write("a=");
        a = int.Parse( Console.ReadLine());
        while (不結束)
        {
            Console.Write("b=");
            try
            {
            b = int.Parse( Console.ReadLine());
                Console.WriteLine("a/b={0}", a/b);
                不結束 = false;
            }
            catch 
            {
            Console.WriteLine("被除數不可為 0 !\n");
            }
        }
        
    }
}