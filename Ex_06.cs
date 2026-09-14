using System;
namespace BT_Buoi4
{
	public class Ex_06
	{
		public static void Run()
		{
			while (true)
			{
                Console.WriteLine("Trạng thái = ");
                if (int.TryParse(Console.ReadLine(), out int trangThai) && trangThai >= 1 && trangThai <= 5)
                {
					switch (trangThai)
					{
						case 1:
							Console.WriteLine(" Chờ xác nhận thanh toán !");
							break;
                        case 2:
                            Console.WriteLine(" Đang đóng gói và bàn giao đơn vị vận chuyển !");
                            break;
                        case 3:
                            Console.WriteLine(" Đơn hàng đang trên đường giao đến bạn!");
                            break;
                        case 4:
                            Console.WriteLine(" Đơn hàng đã hoàn thành! Cảm ơn bạn !");
                            break;
                        case 5:
                            Console.WriteLine(" Đơn hàng đã huỷ! Xuất phiếu hoàn tiền !");
                            break;
                    }

                }
				else
				{ Console.WriteLine("Lỗi nhập số! Vui lòng nhập mã trạng thái từ 1 đến 5"); }

            }
			
		}
	}
}

