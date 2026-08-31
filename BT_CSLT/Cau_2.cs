using System;
namespace Buoi_3
{
	public class Cau_2
	{
		public static void Run()
		{
			Console.Write("Chiều cao (m): ");
			double.TryParse(Console.ReadLine(), out double chieuCao);
            Console.Write("Cân nặng (kg): ");
			double.TryParse(Console.ReadLine(), out double canNang);
			double chiSoBMI = canNang / Math.Pow(chieuCao, 2);
			Console.WriteLine($"Chỉ số BMI của bạn: {chiSoBMI:N2}");
			if (chiSoBMI<18.5)
			{
				Console.WriteLine("Phân loại sức khoẻ: Gầy (Thiếu cân)");
			}
			else if (chiSoBMI<23.0)
			{
				Console.WriteLine("Phân loại sức khoẻ: Bình thường (Lý Tưởng)");
			}
			else if (chiSoBMI<25.0)
			{
				Console.WriteLine("Phân loại sức khoẻ: Thừa cân (Tiền Béo phì)");
			}
			else
			{
				Console.WriteLine("Phân loại sức khoẻ: Béo phì");
			}
			double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
			double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);
			Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangToiThieu:N2} kg đếb {canNangToiDa:N2} kg");
        }
    }
}

