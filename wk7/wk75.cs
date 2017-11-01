using System;
namespace 命名空間1
{
    public class 類別1
    {
        public static void Main()
        {
            Random 亂數物件 = new Random();
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("座號:{0} 分數:{1}", i+1, 60 + 亂數物件.Next(36));
            }
        }
    }
}