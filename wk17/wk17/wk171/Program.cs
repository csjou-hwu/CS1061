using System;

namespace wk171
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                if (!(i == 5 || i==8))
                  Console.WriteLine("Hello 周重石 {0}!", i);
                /*
                if (i == 5 || i==8)
                {}
                else
                {
                  Console.WriteLine("Hello 周重石 {0}!", i);
                }
                */          
            }
        }
    }
}
