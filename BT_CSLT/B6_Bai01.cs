using System;

namespace BT_Buoi4
{
    public class buoi6
    {
        public static int TinhTong(int a, int b)
        {
            return a + b;
        }

        public static void Run()
        {
            Console.WriteLine("--- Bài 1: Tính tổng hai số nguyên ---");
            Console.Write("Nhập số a: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Nhập số b: ");
            int.TryParse(Console.ReadLine(), out int b);

            int result = TinhTong(a, b);
            Console.WriteLine($"Kết quả: {a} + {b} = {result}");
        }
    }
}