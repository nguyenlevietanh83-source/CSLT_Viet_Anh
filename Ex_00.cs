using System;
namespace BT_Buoi4
{
	public class Ex_00
	{
		public static void Run()
		{
			Read_number_v2();
		}
		static void Read_number_v1()
		{

			Console.WriteLine(" Nhập từ số 0 -> 9 = ");
			int so = int.Parse(Console.ReadLine ());
			if (so == 0) Console.WriteLine("Số không");
			else if (so == 1) Console.WriteLine("Số một");
			else if (so == 2) Console.WriteLine("Số hai");
			else if (so == 3) Console.WriteLine("Số ba");
			else if (so == 4) Console.WriteLine("Số bốn");
			else if (so == 5) Console.WriteLine("Số năm");
			else if (so == 6) Console.WriteLine("Số sáu");
			else if (so == 7) Console.WriteLine("Số bảy");
			else if (so == 8) Console.WriteLine("Số tám");
			else if (so == 9) Console.WriteLine("Số chín");
			else Console.WriteLine("Không xác định");
		}
        static void Read_number_v2()
		{
            Console.WriteLine(" Nhập từ số 0 -> 9 = ");
            bool laso = int.TryParse(Console.ReadLine(),out int so);
			if (laso)
			{
				switch (so)
				{
					case 0: Console.WriteLine("Số không"); break;
					case 1: Console.WriteLine("Số một"); break;
					case 2: Console.WriteLine("Số hai"); break;
					case 3: Console.WriteLine("Số ba"); break;
					case 4: Console.WriteLine("Số bốn"); break;
					case 5: Console.WriteLine("Số năm"); break;
					case 6: Console.WriteLine("Số sáu"); break;
					case 7: Console.WriteLine("Số bảy"); break;
					case 8: Console.WriteLine("Số tám"); break;
					case 9: Console.WriteLine("Số chín"); break;
					default: Console.WriteLine("Không xác định"); break;
				};
			}
			else Console.WriteLine("Bạn nhập không hợp lệ");
        }

    }
}

