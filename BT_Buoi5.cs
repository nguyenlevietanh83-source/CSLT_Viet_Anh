using System;
using System.Text;

namespace BT_Buoi4
{
    public class BT_Buoi5
    {
        public BT_Buoi5()
        {
            static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;


                DiceGame(); 
            }

            static void DiceGame()
            {
                long t = 1000000;
                while (t > 0)
                {
                    Console.Write($"Vốn: {t:N0}. Cược: ");
                    if (!long.TryParse(Console.ReadLine(), out long bet) || bet <= 1000 || bet > t) continue;
                    int sum = new Random().Next(1, 7) + new Random().Next(1, 7);
                    Console.Write("Đoán (t/x/l): ");
                    string g = Console.ReadLine()?.ToLower();
                    bool win = (g == "t" && sum > 6) || (g == "x" && sum < 6) || (g == "l" && sum == 6);
                    t += win ? (g == "l" ? bet * 3 : bet) : -bet;
                    Console.WriteLine($"Tổng {sum} -> {(win ? "Thắng" : "Thua")}. Vốn mới: {t:N0}\nChơi tiếp? (c/k): ");
                    if (Console.ReadLine()?.ToLower() == "k") break;
                }
            }

            static void GuessGame()
            {
                long t = 1000000;
                while (t > 0)
                {
                    Console.Write($"Vốn: {t:N0}. Cược: ");
                    if (!long.TryParse(Console.ReadLine(), out long bet) || bet <= 0 || bet > t) continue;
                    int secret = new Random().Next(1, 101), turns = 6;
                    bool win = false;
                    for (int i = 1; i <= turns; i++)
                    {
                        Console.Write($"Đoán ({i}/{turns}): ");
                        if (!int.TryParse(Console.ReadLine(), out int guess)) continue;
                        if (guess == secret) { win = true; break; }
                        Console.WriteLine(guess < secret ? "-> Lớn hơn" : "-> Nhỏ hơn");
                    }
                    t += win ? bet : -bet;
                    Console.WriteLine($"{(win ? "Thắng" : "Thua")}. Số đúng: {secret}. Vốn: {t:N0}\nChơi tiếp? (c/k): ");
                    if (Console.ReadLine()?.ToLower() == "k") break;
                }
            }

            static void Harmonic()
            {
                Console.Write("Nhập n: ");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    double sum = 0;
                    for (int i = 1; i <= n; i++) sum += 1.0 / i;
                    Console.WriteLine($"Tổng chuỗi điều hòa: {sum:F4}");
                }
            }

            static void Perfect()
            {
                Console.Write("Nhập min và max (cách nhau khoảng trắng): ");
                string[] p = Console.ReadLine()?.Split(' ');
                if (p != null && p.Length >= 2 && int.TryParse(p[0], out int min) && int.TryParse(p[1], out int max))
                {
                    for (int num = min; num <= max; num++)
                    {
                        int sum = 0;
                        for (int i = 1; i <= num / 2; i++) if (num % i == 0) sum += i;
                        if (sum == num) Console.WriteLine($"Tìm thấy số hoàn hảo: {num}");
                    }
                }
            }
        }
    }
}
