using System;
namespace Buoi_3
{
	public class Buoi7_Cau3
	{
		public Buoi7_Cau3()
		{
            static void Main()
            {
                int n = 3; // Số hàng
                int m = 3; // Số cột
                int[,] matrix = new int[n, m];

                // 1. Nhập giá trị thủ công hoặc gán giá trị đơn giản cho ma trận
                int giaTri = 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = giaTri;
                        giaTri++;
                    }
                }

                // 2. In ma trận dạng bảng
                Console.WriteLine("Ma trận 3x3:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(matrix[i, j] + "\t"); // Ký tự \t tạo khoảng cách đều nhau
                    }
                    Console.WriteLine(); // Xuống dòng khi hết một hàng
                }

                // 3. Tìm số lớn nhất trong ma trận
                int maxMatrix = matrix[0, 0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i, j] > maxMatrix)
                        {
                            maxMatrix = matrix[i, j];
                        }
                    }
                }
                Console.WriteLine($"\nGiá trị lớn nhất trong ma trận là: {maxMatrix}");
            }
        }
	}
}

