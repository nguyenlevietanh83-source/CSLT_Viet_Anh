using System;

namespace buoi6
{
    public class Bai02
    {
        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 2: Kiểm tra số chẵn lẻ ---");
            Console.Write("Nhập số n: ");
            int.TryParse(Console.ReadLine(), out int n);

            bool isChan = KiemTraChan(n);
            Console.WriteLine($"Số {n} là số {(isChan ? "chẵn" : "lẻ")}");
        }
    }
}