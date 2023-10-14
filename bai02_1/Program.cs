using bai02_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai02_1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Nhap tong so sinh vien n= ");
                int N = Convert.ToInt32(Console.ReadLine());
                SinhVien[] arrSinhVien = new SinhVien[N];
                Console.WriteLine("\n ///////////Nhap danh sach SV///////////");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Nhap sinh vien thu {0}:", i + 1);
                    arrSinhVien[i] = new SinhVien();
                    arrSinhVien[i].NhapSV();
                }
                Console.WriteLine("\n //////Xuat danh sach SV//////");
                foreach (SinhVien sv in arrSinhVien)
                {
                    sv.XuatSV();
                }
                Console.ReadKey();
            }
        }
    }