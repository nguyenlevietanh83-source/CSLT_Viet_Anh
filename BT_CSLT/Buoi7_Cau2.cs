using System;
namespace Buoi_3
{
	public class Buoi7_Cau2
	{
		public Buoi7_Cau2()
		{
            static void Main()
            {
                // --- 1. Sắp xếp 10 số bằng Bubble Sort ---
                int[] a = { 9, 2, 5, 1, 8, 3, 7, 4, 6, 10 };

                // Vòng lặp ngoài duyệt qua các lượt
                for (int i = 0; i < a.Length - 1; i++)
                {
                    // Vòng lặp trong đẩy số lớn nhất về cuối mảng
                    for (int j = 0; j < a.Length - i - 1; j++)
                    {
                        if (a[j] > a[j + 1]) // Nếu số trước lớn hơn số sau thì đổi chỗ
                        {
                            int tam = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = tam;
                        }
                    }
                }

                Console.Write("Mảng sau khi sắp xếp tăng dần: ");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }

                // --- 2. Tìm kiếm từ bằng Linear Search trong câu ---
                Console.WriteLine("\n\n--- Tìm kiếm từ ---");
                string[] tuTrongCau = { "toi", "dang", "hoc", "lap", "trinh", "csharp" };
                string tuCanTim = "hoc";
                bool timThay = false;

                // Duyệt qua từng từ để so sánh
                for (int i = 0; i < tuTrongCau.Length; i++)
                {
                    if (tuTrongCau[i] == tuCanTim)
                    {
                        timThay = true;
                        break; // Tìm thấy thì dừng vòng lặp ngay
                    }
                }

                if (timThay)
                    Console.WriteLine($"Tìm thấy từ '{tuCanTim}' trong câu!");
                else
                    Console.WriteLine($"Không tìm thấy từ '{tuCanTim}'.");
            }
        }
	}
}

