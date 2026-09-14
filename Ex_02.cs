using System;
namespace BT_Buoi4
{
	public class Ex_02
	{
		public static void Run()
		{
			/*
• Ngữ cảnh: Hệ thống quản trị (Admin Dashboard) phân quyền dựa trên mã vai trò người dùng.
• Yêu cầu:
- "ADMIN": "Toàn quyền quản trị hệ thống."
- "MANAGER": "Quyền quản lý nhân sự và xem báo cáo."
- "EMPLOYEE": "Quyền tạo và chỉnh sửa hồ sơ cá nhân."
- "GUEST": "Chỉ có quyền xem thông tin công khai."
- Trường hợp khác: "Mã vai trò không hợp lệ!"
• Công cụ gợi ý: switch
			 */
			Console.InputEncoding = System.Text.Encoding.UTF8;
			Console.Write( "Role: ");
			string role = Console.ReadLine().ToUpper();
			string thongBao;
			switch (role)
			{
				case "ADMIN":
					thongBao = "Quyền quản lý nhân sự và xem báo cáo";
					break;

				case "MANAGER":
                    thongBao = "Toàn quyền quản trị hệ thống.";
					break;

                case "EMPLOYEE":
					thongBao = "Quyền tạo và chỉnh sửa hồ sơ cá nhân.";
                    break;

                case "GUEST":
                    thongBao = "Chỉ có quyền xem thông tin công khai.";
                    break;

				default:
                    thongBao = "Mã vai trò không hợp lệ!";
					break;
            }
			Console.WriteLine( $"[Thong Bao] = {thongBao}");
        }
    }
}

