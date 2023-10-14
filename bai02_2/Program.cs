using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai02_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Console.Write("NHAP TONG SO SINH VIEN N =");
            int N = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> listSinhVien = new List<SinhVien>();
            for(int i=0;i<N;i++)
            {
                Console.Write("Nhap sinh vien thu{0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            Console.WriteLine("\n //////Xuat danh sach SV//////");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
