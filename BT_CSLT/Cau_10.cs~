using System;

namespace Buoi_3
{
    public enum StockStatus
    {
        OutOfStock,
        LowStock,
        InStock,
        Discontinued
    }

    public class Cau10
    {
        public static void Run()
        {
            string maSP = "KB-09";
            string tenSP = "Bàn phím Cơ Akko";
            int? quantity = null;
            int minThreshold = 10; 
            DateTime? restockDate = null; 


            Console.WriteLine($"Sản phẩm: {tenSP} (Mã: {maSP})");
            Console.WriteLine($"Số lượng tồn kho: {(quantity.HasValue ? quantity.Value.ToString() : "null (Chưa kiểm kê)")}");
            Console.WriteLine($"Restock Date: {(restockDate.HasValue ? restockDate.Value.ToString("dd/MM/yyyy") : "null")}");

            int displayQuantity = quantity ?? 0;

            StockStatus status;
            if (quantity == null || quantity == 0)
            {
                status = StockStatus.OutOfStock;
            }
            else if (quantity < minThreshold)
            {
                status = StockStatus.LowStock;
            }
            else
            {
                status = StockStatus.InStock;
            }

            string restockDateText = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";

            Console.WriteLine($"Số lượng hiển thị: {displayQuantity} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");

            string statusText = status switch
            {
                StockStatus.OutOfStock => "OutOfStock (Hết hàng)",
                StockStatus.LowStock => "LowStock (Sắp hết hàng)",
                StockStatus.InStock => "InStock (Còn hàng)",
                _ => "Discontinued (Ngừng kinh doanh)"
            };
            Console.WriteLine($"Trạng thái kho: {statusText}");
            Console.WriteLine($"Dự kiến nhập hàng: {restockDateText}");
        }
    }
}