using System;

namespace Buoi_3
{
    public class Cau9
    {
        public static void Run()
        {

            Console.Write("Lương Gross: ");
            decimal.TryParse(Console.ReadLine(), out decimal luongGross);

            Console.Write("Số người phụ thuộc: ");
            int.TryParse(Console.ReadLine(), out int soNguoiPhuThuoc);

            decimal giamTruBaoHiem = luongGross * 0.105m;

            decimal giamTruBanThan = 11000000m;
            decimal giamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;

            decimal thuNhapChiuThue = luongGross - giamTruBaoHiem - giamTruBanThan - giamTruPhuThuoc;

            if (thuNhapChiuThue < 0)
            {
                thuNhapChiuThue = 0;
            }

            decimal thueTNCN = 0;

            if (thuNhapChiuThue > 0)
            {
                if (thuNhapChiuThue <= 5000000m)
                {
                    thueTNCN = thuNhapChiuThue * 0.05m;
                }
                else if (thuNhapChiuThue <= 10000000m)
                {
                    thueTNCN = (5000000m * 0.05m) + (thuNhapChiuThue - 5000000m) * 0.10m;
                }
                else if (thuNhapChiuThue <= 18000000m)
                {
                    thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (thuNhapChiuThue - 10000000m) * 0.15m;
                }
                else if (thuNhapChiuThue <= 32000000m)
                {
                    thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (thuNhapChiuThue - 18000000m) * 0.20m;
                }
                else
                {
                    thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + (thuNhapChiuThue - 32000000m) * 0.25m;
                }
            }

            decimal luongNet = luongGross - giamTruBaoHiem - thueTNCN;

            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {giamTruBaoHiem:N0} VNĐ");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0} VNĐ");
        }
    }
}