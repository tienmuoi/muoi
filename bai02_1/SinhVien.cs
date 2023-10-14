using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai02_1
{
    internal class SinhVien
    {
        private string _MaSV;
        private string _Hoten;
        private double _DiemTB;
        private string _Khoa;
        public SinhVien() { }
        //public SinhVien(string masv, string hoten, double diemtb, string khoa)
        //{
        //    this._MaSV = masv;
        //    this._Hoten = hoten;
        //    this._DiemTB = diemtb;
        //    this._Khoa = khoa;
        //}
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }
        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }
        public double DiemTB
        {
            get { return _DiemTB; }
            set { _DiemTB = value; }
        }
        public string Khoa
        {
            get { return _Khoa; }
            set { _Khoa = value; }
        }
        public void NhapSV()
        {
            Console.Write("\nNhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();

        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0} \t Hoten: {1} \t DiemTB: {2} \t Khoa: {3} \t", MaSV, Hoten, DiemTB, Khoa);
        }
    }
}
