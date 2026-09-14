using System;
namespace BT_Buoi4
{
	public class Ex_07
	{
		public static void Run()
		{
			while (true)
			{
				Console.WriteLine("Nhập chiều cao: ");
				bool chieuCaoDung = double.TryParse(Console.ReadLine(), out double chieuCao);
                Console.WriteLine("Nhập cân nặng: ");
                bool canNangDung = double.TryParse(Console.ReadLine(), out double canNang);
                if (chieuCaoDung && canNangDung && chieuCao > 0 && canNang > 0)
                {
                    double bmi = canNang / (chieuCao * chieuCao);
                    Console.WriteLine($"BMI: {bmi:F2}");

                    if (bmi < 18.5)
                    {
                        Console.WriteLine("Đánh giá: Gầy - Nên bổ sung dinh dưỡng.");
                    }
                    else if (bmi < 25)
                    {
                        Console.WriteLine("Đánh giá: Cân đối - Tiếp tục duy trì.");
                    }
                    else if (bmi < 30)
                    {
                        Console.WriteLine("Đánh giá: Thừa cân - Nên tăng cường luyện tập.");
                    }
                    else
                    {
                        Console.WriteLine("Đánh giá: Béo phì - Cần sự tư vấn từ bác sĩ.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Lỗi nhập liệu! Vui lòng nhập số lớn hơn 0.\n");
                }
            }
        
    
		}
	}
}

