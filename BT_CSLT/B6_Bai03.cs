using System;
<<<<<<< HEAD

namespace buoi6
{
    public class Bai03
    {
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 3: Tìm số lớn nhất trong ba số ---");
            Console.Write("Nhập a: "); int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Nhập b: "); int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Nhập c: "); int.TryParse(Console.ReadLine(), out int c);

            Console.WriteLine($"Số lớn nhất là: {TimMax(a, b, c)}");
        }
    }
}
=======
namespace Buoi_3
{
	public class B6_Bai03
	{
		public B6_Bai03()
		{
		}
	}
}

>>>>>>> 8f66d7cd87cc56b22662cca4900b5a64f7edcd7d
