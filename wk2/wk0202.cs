using System;
namespace 命名空間1
{
	class 類別1
	{
			public static void Main()
			{
				Console.WriteLine("Hi!");
				類別2.類別方法();
				類別2 物件 = new 類別2(); // 建立物件
				物件.物件方法();
			}
	}
	class 類別2
	{
			public 類別2()   //建構元方法
			{
				Console.WriteLine("建構元方法!");
			}
			public static void 類別方法()
			{
				Console.WriteLine("類別方法!");
			}
			public void 物件方法()
			{
				Console.WriteLine("物件方法!");
			}
			
	}
}