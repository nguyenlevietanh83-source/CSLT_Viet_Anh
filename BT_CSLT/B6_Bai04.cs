using System;
<<<<<<< HEAD

namespace buoi6
{
    public class Bai04
    {
        public static long TinhGiaiThua(int n)
        {
            if (n < 0) return -1;
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 4: Tính giai thừa ---");
            Console.Write("Nhập n (n >= 0): ");
            int.TryParse(Console.ReadLine(), out int n);

            long res = TinhGiaiThua(n);
            Console.WriteLine(res != -1 ? $"{n}! = {res}" : "Giá trị không hợp lệ!");
        }
    }
}
=======
namespace Buoi_3
{
	public class B6_Bai04
	{
		public B6_Bai04()
		{
		}
	}
}

>>>>>>> 8f66d7cd87cc56b22662cca4900b5a64f7edcd7d
