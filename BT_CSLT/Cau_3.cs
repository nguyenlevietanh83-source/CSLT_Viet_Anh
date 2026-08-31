using System;
namespace Buoi_3
{
	public enum LoaiTien{
		USD = 1,
		EURO = 2,
		JPY = 3,
		GBP = 4,
	}
    public class Cau_3
	{
        public static void Run()
		{
       // decimal 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP = 32,100 VNĐ
	        Console.Write ("Nhập số tiền VNĐ: ");
			decimal.TryParse(Console.ReadLine(), out decimal soTien);
			Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
			int.TryParse(Console.ReadLine(), out int chon);
			LoaiTien chonLoai = (LoaiTien)chon;
			decimal tyGia = 0;
			string kyHieu = "";
			switch (chonLoai)
			{
				case LoaiTien.USD:
					tyGia = 25400m;
					kyHieu = "USD";
					break;
				case LoaiTien.EURO:
					tyGia = 27200m;
					kyHieu = "EUR";
					break;
                case LoaiTien.JPY:
                    tyGia = 165m;
                    kyHieu = "JPY";

                    break;
                case LoaiTien.GBP:
                    tyGia = 32100m;
                    kyHieu = "GBP";

                    break;
            }
            decimal phiDichVu = 0.005m * soTien;
			Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
			decimal soTienTinhDoi = soTien - phiDichVu;
			Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienTinhDoi:N0} VNĐ");
			decimal soTienNhanDuoc = soTienTinhDoi / tyGia;
            Console.WriteLine($"Số tiền USD nhận được: {soTienNhanDuoc:N2} {kyHieu}");
		}
	}
}

