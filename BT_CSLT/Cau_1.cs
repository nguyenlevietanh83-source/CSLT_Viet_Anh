using System;

namespace Buoi_3  // <--- Lệnh 'using Buoi_3;' ở program.cs sẽ nhận diện được
{
    public class Cau_1
    {
        public static void Run()
        {
            // Code câu 1 của bạn ở đây...

            decimal soDienMoi, soDienCu;
            do
            { 
                Console.Write("Nhập số điện mới: ");
                decimal.TryParse(Console.ReadLine(), out soDienMoi);
                Console.Write("Nhập số điện cũ: ");
                decimal.TryParse(Console.ReadLine(), out soDienCu);
                if (soDienMoi < soDienCu)
                {
                    Console.WriteLine("Số điện mới phải lớn hơn số điện cũ. Vui lòng nhập lại!");
                }

            }
            while (soDienMoi < soDienCu);
            decimal soLuongDien = soDienMoi - soDienCu;
            Console.WriteLine($"Số lượng điện đã tiêu thụ là {soLuongDien:N0} kWh");
            decimal tong=0;
            if (soLuongDien > 0 && soLuongDien < 51)
            {
                tong = soLuongDien * 1806;
                Console.WriteLine($" Tiền điện chưa thuế là {tong:N0}");
            }
            else if (soLuongDien > 50 && soLuongDien < 101)
            {
                tong = 50 * 1806 + (soLuongDien - 50) * 1866;
                Console.WriteLine($" Tiền điện chưa thuế là {tong:N0}");

            }
            else if (soLuongDien < 201)
            {
                tong = 50 * 1806 + 50 * 1866 + (soLuongDien - 100) * 2167;
                Console.WriteLine($" Tiền điện chưa thuế là {tong:N0}");

            }
            else if (soLuongDien < 301)
            {
                tong = 50 * 1806 + 50 * 1866 + 100 * 2167 + (soLuongDien - 200) * 2729;
                Console.WriteLine($"Tiền điện chưa thuế là {tong:N0} VNĐ");

            }
            else if (soLuongDien > 300)
            {
                tong = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (soLuongDien - 300) * 3050;
                Console.WriteLine($" Tiền điện chưa thuế là {tong:N0} VNĐ");
            }
            decimal thue = 0.08m * tong;
            Console.WriteLine($"Thuế VAT là {thue:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán là {tong + thue:N0} VNĐ");
        }
    }
}