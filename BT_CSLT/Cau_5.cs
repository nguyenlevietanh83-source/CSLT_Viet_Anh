using System;
namespace Buoi_3
{
    public enum XepLoai
    {
        XuatSacGioi,
        Kha,
        TrungBinh,
        Yeu,
        Kem
    }
    public class Cau_5
	{
		public static void Run()
		{
            int tc1 = 4; // C#
            int tc2 = 3; // Toán rời rạc
            int tc3 = 2; // Tiếng Anh

            Console.Write($"C# ({tc1} TC): ");
            double.TryParse(Console.ReadLine(), out double diem1);

            Console.Write($"Toán ({tc2} TC): ");
            double.TryParse(Console.ReadLine(), out double diem2);

            Console.Write($"Tiếng Anh ({tc3} TC): ");
            double.TryParse(Console.ReadLine(), out double diem3);

            // Tính điểm trung bình trọng số (Score_Avg)
            double scoreAvg = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3) / (tc1 + tc2 + tc3);

            // Khai báo các biến quy đổi
            char diemChu;
            double gpa4;
            XepLoai loaiHocLuc;
            string tenXepLoai = "";

            // Quy đổi thang điểm theo điều kiện đề bài
            if (scoreAvg >= 8.5)
            {
                diemChu = 'A';
                gpa4 = 4.0;
                loaiHocLuc = XepLoai.XuatSacGioi;
                tenXepLoai = "Xuất sắc / Giỏi";
            }
            else if (scoreAvg >= 7.0)
            {
                diemChu = 'B';
                gpa4 = 3.0;
                loaiHocLuc = XepLoai.Kha;
                tenXepLoai = "Khá";
            }
            else if (scoreAvg >= 5.5)
            {
                diemChu = 'C';
                gpa4 = 2.0;
                loaiHocLuc = XepLoai.TrungBinh;
                tenXepLoai = "Trung bình";
            }
            else if (scoreAvg >= 4.0)
            {
                diemChu = 'D';
                gpa4 = 1.0;
                loaiHocLuc = XepLoai.Yeu;
                tenXepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                gpa4 = 0.0;
                loaiHocLuc = XepLoai.Kem;
                tenXepLoai = "Kém (Trượt)";
            }

            Console.WriteLine($"Điểm TB Thang 10: {scoreAvg:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa4:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {tenXepLoai}");
            Console.WriteLine($"Enum Xếp Loại: {loaiHocLuc}");
        }
	}
}

