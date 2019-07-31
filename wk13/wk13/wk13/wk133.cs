using System;
namespace 命名空間1
{
    class 類別1
    {
        public static void Main()
        {
            int [] 整數陣列 = {1,13,5,12,4};
            Array.Sort(整數陣列);
            for (int i=0; i<整數陣列.Length; i++)
            {
                Console.WriteLine(" i= {0}, 整數陣列[{0}] = {1} ",
                i, 整數陣列[i]);
            }
            Random rnd=new Random();
            string [] MyRandomArray = 整數陣列.OrderBy(x => rnd.Next()).ToArray();
                for (int i=0; i<整數陣列.Length; i++)
            {
                Console.WriteLine(" i= {0}, 整數陣列[{0}] = {1} ",
                i, MyRandomArray[i]);
            }   
        }
    }
}