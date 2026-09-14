using System;
namespace BT_Buoi4
{
	public class Ex_03
	{
		public static void Run()
        {
			/*
• Ngữ cảnh: Máy ATM thực hiện kiểm tra tính hợp lệ của giao dịch rút tiền.
• Yêu cầu:
-Nhập số dư tài khoản và số tiền muốn rút.
- Số tiền rút phải lớn hơn 0.
- Số tiền rút phải là bội số của 50,000 VNĐ.
- Số tiền rút không vượt quá số dư hiện tại.
- Hạn mức rút tối đa 5,000,000 VNĐ / lần.
- Xuất ra lý do từ chối cụ thể nếu không đủ điều kiện, hoặc thông báo rút thành công.
• Công cụ gợi ý: if-else
			*/
			while (true)
			{
                Console.Write("So du tai khoan: ");
                bool soDuDung = int.TryParse(Console.ReadLine(), out int soDu);
                Console.Write("So tien muon rut: ");
                bool soRutDung = int.TryParse(Console.ReadLine(), out int soRut);
                if (soDuDung && soRutDung)
                {
                    if (soRut <=0)
                    {
                        Console.WriteLine( "Giao dich that bai! So tien rut phai lon hon 0! Vui long nhap lai!");
                    }
                    else if (soRut % 50000 != 0)
                    {
                        Console.WriteLine("Giao dich that bai! So tien rut phai la boi so cua 50.000VND! Vui long nhap lai!");
                    }
                    else if (soRut > soDu)
                    {
                        Console.WriteLine("Giao dich that bai! So tien rut khong duoc vuot qua so du hien tai! Vui long nhap lai!");
                    }
                    else if (soRut > 5000000)
                    {
                        Console.WriteLine("Giao dich that bai! Han muc toi da 5.000.000 VND/ lan! Vui long nhap lai!");
                    }
                    else
                    {
                        int soDuConLai = soDu - soRut;
                        Console.WriteLine( $"Gia dich thanh cong! So du con lai la: {soDuConLai}");
                        break;
                    }


                }


            }



        }



    }
}

