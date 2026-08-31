using System;

namespace Buoi_3
{
    public class Cau8
    {
        public static void Run()
        {
            string otpHeThong = "839201";
            DateTime creationTime = DateTime.Now;

            Console.Write("Mã OTP nhận được: ");
            string otpNhap = Console.ReadLine() ?? "";
            Console.Write("Thời gian trôi qua (phút): ");
            int.TryParse(Console.ReadLine(), out int minutets);

            Console.Write("Thời gian trôi qua (giây): ");
            int.TryParse(Console.ReadLine(), out int seconds);

            TimeSpan timePassed = new TimeSpan(0, 0, minutets, seconds);
            DateTime verifyTime = creationTime.Add(timePassed);

            TimeSpan duration = verifyTime - creationTime;


            bool isSixDigits = otpNhap != null && otpNhap.Length == 6;
            bool isAllNumeric = int.TryParse(otpNhap, out _) && !otpNhap.Contains("-") && !otpNhap.Contains("+");
            bool isValidFormat = isSixDigits && isAllNumeric;

            bool isOtpMatched = (otpNhap == otpHeThong);

            bool isNotExpired = duration.TotalSeconds <= 300;

            if (!isValidFormat)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Định dạng OTP không hợp lệ (Phải đúng 6 chữ số).");
            }
            else if (!isNotExpired)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã OTP đã hết hạn (Quá 5 phút).");
            }
            else if (!isOtpMatched)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã OTP sai.");
            }
            else
            {
                Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt.");
            }
        }
    }
}