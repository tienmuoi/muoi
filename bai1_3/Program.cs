using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Nhập số nguyên dương n từ người dùng
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo biến tổng để lưu tổng các số lẻ
            int tong = 0;

            // Sử dụng vòng lặp để tính tổng các số lẻ từ 1 đến 2n-1
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                tong += i;
            }

            // In kết quả tổng
            Console.WriteLine($"Tổng các số lẻ từ 1 đến {2 * n - 1} là: {tong}");
        }
    }
}
