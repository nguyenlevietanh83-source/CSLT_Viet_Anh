using System;

namespace buoi6
{
    public class Bai06
    {
        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 6: Kiểm tra số nguyên tố ---");
            Console.Write("Nhập n: ");
            int.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine($"Input: {n} -> Output: {KiemTraNguyenTo(n)}");
        }
    }
}