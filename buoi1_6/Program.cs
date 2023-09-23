using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi1_6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Nhập các hệ số a, b, và c từ người dùng
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());

            // Tính delta
            double delta = b * b - 4 * a * c;

            // Kiểm tra giá trị của delta để xác định số nghiệm và tính nghiệm
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm thực phân biệt:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có một nghiệm kép:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình không có nghiệm thực.");
            }
        }
    }
}
