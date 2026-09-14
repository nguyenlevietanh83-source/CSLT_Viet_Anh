using System;
namespace BT_Buoi4
{
	public class Ex_05
	{
		public static void Run()
		{
            while (true)
            {
                Console.WriteLine("Số km : ");
                bool soKmDung = double.TryParse(Console.ReadLine(), out double soKm);
                if (soKmDung && soKm > 0)
                {
                    double gia = 0;
                    if (soKm < 1)
                    {
                        gia = soKm * 15000;
                    }
                    else if (soKm <= 10)
                    {
                        gia = 1 * 15000 + (soKm - 1) * 12000;
                    }
                    else
                    {
                        gia = 1 * 15000 + 9 * 12000 + (soKm - 10) * 10000;
                    }
                    double khuyenMai = 0;
                    if (soKm > 30)
                    {
                        khuyenMai = -gia * 0.1;
                    }
                    else
                    {
                        khuyenMai = 0;
                    }
                    double thanhTien = gia + khuyenMai;
                    Console.WriteLine($"Tổng tiển trước giảm: {gia:N0} VNĐ");
                    if (soKm >30)
                    {
                        Console.WriteLine($"Khuyến mãi (10%): -{khuyenMai:N0} VNĐ");
                    }
                    Console.WriteLine ($"Thành Tiền : {thanhTien} VNĐ");
                    break;
                }
                else
                {
                    Console.WriteLine("Bạn đã nhập sai! Vui lòng nhập số km lớn hơn 0!");
                }

            }
		



        }
	}
}

