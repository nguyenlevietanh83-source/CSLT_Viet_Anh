using System;
namespace BT_Buoi4
{
	public class Ex_04
	{
		public static void Run()
		{
			Console.Write("Phim bam = ");
			bool phimDung = int.TryParse(Console.ReadLine(), out int phim);
			switch (phim)
			{
				case 1:
					Console.WriteLine(" Gặp tổng đài viên tư vấn thẻ.");
					break;
				case 2:
					Console.WriteLine(" Tra cứu số dư tài khoản.");
					break;
                case 3:
                    Console.WriteLine(" Báo khóa thẻ khẩn cấp.");
                    break;
                case 4:
                    Console.WriteLine(" Tra cứu số dư tài khoản.");
                    break;
				case 0:
                    Console.WriteLine(" Quay lại menu chính.");
                    break;
				default:
					{   
						break;
					}
            }




		}
	}
}

