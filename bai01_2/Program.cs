using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai01_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //khai bao bien
            int  songay,thang, nam;
            //nhap thang
            Console.Write(" nhap nhap thang : ");
            thang = Int32.Parse(Console.ReadLine());
            //nhap nam
            Console.Write(" nhap nhap nam : ");
            nam = Int32.Parse(Console.ReadLine());
            int soNgay = SoNgayTrongThang(thang, nam);

            Console.WriteLine("Số ngày trong tháng là: " + soNgay);
        }
        static bool CheckNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }
        static int SoNgayTrongThang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (CheckNamNhuan(nam))
                        return 29;
                    else
                        return 28;
                default:
                    return -1;
            }
        }

    }
}
