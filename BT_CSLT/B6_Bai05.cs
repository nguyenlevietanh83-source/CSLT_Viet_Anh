using System;
<<<<<<< HEAD

namespace buoi6
{
    public class Bai05
    {
        public static string DaoNguocChuoi(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 5: Đảo ngược chuỗi ---");
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine() ?? "";

            Console.WriteLine($"Chuỗi đảo ngược: {DaoNguocChuoi(input)}");
        }
    }
}
=======
namespace Buoi_3
{
	public class B6_Bai05
	{
		public B6_Bai05()
		{
		}
	}
}

>>>>>>> 8f66d7cd87cc56b22662cca4900b5a64f7edcd7d
