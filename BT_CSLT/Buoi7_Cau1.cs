using System;
namespace Buoi_3
{
	public class Buoi7_Cau1
	{
		public Buoi7_Cau1()
		{
            static void Main()
            {
                int[] a = { 5, 2, 9, 7, 1 };

                // 1. Tính giá trị trung bình
                double tong = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    tong += a[i]; // Cộng dồn từng phần tử
                }
                double trungBinh = tong / a.Length;
                Console.WriteLine("1. Giá trị trung bình: " + trungBinh);

                // 2. Tìm Max và Min
                int max = a[0];
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                    if (a[i] < min) min = a[i];
                }
                Console.WriteLine($"2. Số lớn nhất: {max}, Số nhỏ nhất: {min}");
            }
        }
	}
}

