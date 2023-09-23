using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_5
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

            // Xuất các số nguyên tố từ 1 đến n
            Console.WriteLine("Các số nguyên tố từ 1 đến n là:");
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
