using System;
using System.Globalization;

namespace Buoi_3
{
	public class Cau4
	{
		public static void Run()
		{
			Console.Write("Nhập ngày sinh (dd/MM/yyyy):");
			DateTime.TryParseExact(Console.ReadLine(),
			"dd/MM/yyyy",
			CultureInfo.InvariantCulture,
			DateTimeStyles.None,
			out DateTime ngaySinh);

			DateTime ngayHienTai = DateTime.Now.Date;
			int soTuoi = ngayHienTai.Year - ngaySinh.Year;
			DateTime sinhNhatKeTiep = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
			if (sinhNhatKeTiep < ngayHienTai)
			{
				sinhNhatKeTiep = sinhNhatKeTiep.AddYears(1);
            }
            TimeSpan khoangCachSinhNhat = sinhNhatKeTiep - ngayHienTai;
			TimeSpan soNgayDaSong = ngayHienTai - ngaySinh;
			Console.WriteLine($"Tuổi hiện tại: {soTuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {soNgayDaSong.Days} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {khoangCachSinhNhat.Days} ngày");
        }
    }
}

