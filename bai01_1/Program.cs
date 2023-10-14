using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai01_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Khai báo biến
            int a, b, tong, hieu, tich;
            double thuong = 0;

            // Thông báo nhập số a
            Console.Write("Nhập số a: ");

            // Nhập giá trị cho biến a
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số b: ");

            // Nhập giá trị cho biến b và ép kiểu
            b = Int32.Parse(Console.ReadLine());

            // Tính tổng, hiệu, tích, và thương
            tong = a + b;
            hieu = a - b;
            tich = a * b;

            if (b != 0)
            {
                thuong = (double)a / b;
            }

            // Xuất kết quả
            Console.WriteLine("Tổng = " + tong);
            Console.WriteLine("Hiệu = {0}", hieu);
            Console.WriteLine("Tích = {0}, Thương = {1}", tich, thuong);

            // Dừng màn hình để xem kết quả
            Console.ReadKey();
        }
    }
}
