using System;
using System.Text;

namespace BT_Buoi4
{
	public class BT_Buoi5
	{
		public BT_Buoi5()
		{
                Console.OutputEncoding = Encoding.UTF8;
                long tien = 1000_000; // Giả sử người chơi có số vốn ban đầu là 1.000.000 VNĐ
                int soLanChoi = 0;
                int soLanThang = 0;
                int soLanThua = 0;

                Console.WriteLine("""
                 ________                          ________                        
                /  _____/_____   ____   ____      /  _____/_____    _____   ____  
               /   \  ___\__  \ /  _ \ /    \    /   \  ___\__  \  /     \_/ __ \ 
               \    \_\  \/ __ (  <_> )   |  \   \    \_\  \/ __ \|  Y Y  \  ___/ 
                \______  (____  /\____/|___|  /    \______  (____  /__|_|  /\___  >
                       \/     \/            \/            \/     \/      \/     \/ 
                """);

                while (tien > 0)
                {
                    soLanChoi++;
                    Console.WriteLine($"\n-----------------------------------------");
                    Console.WriteLine($"Ván chơi thứ {soLanChoi} | Số dư hiện tại của bạn: {tien:N0} VNĐ");

                    // 1. Nhập và kiểm tra tiền cược
                    long tienDatCuoc = 0;
                    while (true)
                    {
                        Console.Write("Nhập số tiền muốn đặt cược: ");
                        if (long.TryParse(Console.ReadLine(), out long result) && result > 0 && result <= tien)
                        {
                            tienDatCuoc = result;
                            break;
                        }
                        Console.WriteLine($"Lỗi! Tiền cược phải lớn hơn 0 và không được vượt quá số dư hiện có ({tien:N0} VNĐ).");
                    }

                    // 2. Chọn mức độ (Level)
                    int maxTurns = 0;
                    double multiplier = 0;
                    string tenLevel = "";

                    while (true)
                    {
                        Console.Write("Chọn mức độ (1: Dễ - 9 lần đoán | 2: Trung bình - 6 lần đoán | 3: Khó - 4 lần đoán): ");
                        if (int.TryParse(Console.ReadLine(), out int level))
                        {
                            if (level == 1)
                            {
                                maxTurns = 9;
                                multiplier = 0.5; // Thắng được 1/2 tiền đặt
                                tenLevel = "Dễ";
                                break;
                            }
                            else if (level == 2)
                            {
                                maxTurns = 6;
                                multiplier = 1.0; // Thắng được 1 lần đặt
                                tenLevel = "Trung bình";
                                break;
                            }
                            else if (level == 3)
                            {
                                maxTurns = 4;
                                multiplier = 3.0; // Thắng được 3 lần đặt
                                tenLevel = "Khó";
                                break;
                            }
                        }
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chỉ nhập 1, 2 hoặc 3.");
                    }

                    // 3. Máy tính chọn ngẫu nhiên 1 số từ 1 đến 100
                    Random rand = new Random();
                    int secretNumber = rand.Next(1, 101);
                    bool hasWon = false;

                    Console.WriteLine($"\n[Hệ thống] Máy đã chọn xong một số bí mật từ 1 đến 100.");
                    Console.WriteLine($"Mức độ: **{tenLevel}** - Bạn có tối đa **{maxTurns}** lần đoán.");

                    // 4. Vòng lặp đoán số trong giới hạn số lần của level
                    for (int turn = 1; turn <= maxTurns; turn++)
                    {
                        Console.Write($"Lượt đoán {turn}/{maxTurns} - Nhập con số bạn đoán: ");
                        if (int.TryParse(Console.ReadLine(), out int guess))
                        {
                            if (guess == secretNumber)
                            {
                                hasWon = true;
                                break;
                            }
                            else if (guess < secretNumber)
                            {
                                Console.WriteLine("-> Gợi ý: Số bí mật LỚN HƠN số bạn vừa đoán.");
                            }
                            else
                            {
                                Console.WriteLine("-> Gợi ý: Số bí mật NHỎ HƠN số bạn vừa đoán.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Lỗi nhập liệu! Vui lòng nhập vào một số nguyên. Lượt này không bị tính.");
                            turn--; // Không tính lượt nếu người dùng nhập chữ cái hoặc ký tự rác
                        }
                    }

                    // 5. Xử lý kết quả thắng/thua sau khi kết thúc lượt đoán
                    if (hasWon)
                    {
                        long tienThuong = (long)(tienDatCuoc * multiplier);
                        tien += tienThuong;
                        soLanThang++;
                        Console.WriteLine($"\nCHÍNH XÁC! Số bí mật đúng là {secretNumber}. Bạn đã THẮNG!");
                        Console.WriteLine($"Tiền thưởng nhận được (+{multiplier * 100}%): +{tienThuong:N0} VNĐ");
                    }
                    else
                    {
                        tien -= tienDatCuoc;
                        soLanThua++;
                        Console.WriteLine($"\nBẠN ĐÃ THUA! Hết lượt đoán. Số bí mật đúng là: {secretNumber}");
                        Console.WriteLine($"Số tiền bị trừ: -{tienDatCuoc:N0} VNĐ");
                    }

                    Console.WriteLine($"Số dư tài khoản mới: {tien:N0} VNĐ");

                    // Kiểm tra điều kiện dừng nếu tài khoản về 0
                    if (tien <= 0)
                    {
                        Console.WriteLine("\nTài khoản của bạn đã cạn sạch (0 VNĐ). Trò chơi kết thúc!");
                        break;
                    }

                    // 6. Hỏi người dùng có muốn tiếp tục chơi không
                    Console.Write("\nBạn có muốn chơi tiếp ván khác không? (C/K): ");
                    string choice = Console.ReadLine()?.Trim().ToLower();
                    if (choice == "k")
                    {
                        break;
                    }
                }

                // 7. Tổng kết toàn bộ trò chơi khi thoát
                Console.WriteLine("\n================ TỔNG KẾT TRÒ CHƠI ================");
                Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
                Console.WriteLine($"Số ván thắng: {soLanThang}");
                Console.WriteLine($"Số ván thua: {soLanThua}");
                Console.WriteLine($"Số dư cuối cùng: {tien:N0} VNĐ");
                Console.WriteLine("Cảm ơn bạn đã tham gia chương trình!");
            }
        }
    }

