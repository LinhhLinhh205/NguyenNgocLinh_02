using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;

        public NhanVien() { }
        public NhanVien(string maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
        public string Maso
        {
            set { maso = value; }
            get { return maso; }
        }
        public string Hoten
        {
            set { hoten = value; }
            get { return hoten; }
        }
        public int Luongcung
        {
            set { luongcung = value; }
            get { return luongcung; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma so nhan vien:");
            maso = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien:");
            hoten = Console.ReadLine();
            Console.Write("Nhap luong cung nhan vien:");
            luongcung = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return Luongcung;
        }
    }
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;
        public NhanVienBC() { }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai nhan vien:");
            mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double thuong;
            double luongthuclanh;
            switch (mucxeploai)
            {
                case "A":
                    thuong = 1.5 * Luongcung;
                    break;
                case "B":
                    thuong = 1.0 * Luongcung;
                    break;
                case "C":
                    thuong = 0.5 * Luongcung;
                    break;
                default:
                    thuong = 0;
                    break;
            }
            luongthuclanh = Luongcung + thuong;
            return (int)luongthuclanh;


        }
    }
    class NhanVienHD : NhanVien
    {
        private int doanhthu;
        public NhanVienHD() { }
        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu) : base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu nhan vien:");
            doanhthu = int.Parse(Console.ReadLine());

        }
        public override int TinhLuong()
        {
            double luongthuclanh = Luongcung+(0.1 * doanhthu);
            return (int)luongthuclanh;
        }
    }
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();

        }
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("Chon loai [1.Bien che,2.Hop dong]");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban chon sai vui long chon 1 hoac 2");
                        break;
                }
                Console.Write("Ban co muon tiep tuc khong? y/n:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",10}{"Ho ten",20}{"Luong Thuc Lanh",20:#,##0 vnd}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10}{x.Hoten,20}{x.TinhLuong(),20:#,##0 vnd}");
            }

        }
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien a in dsNV)
            {
                sum += a.TinhLuong();
            }
            return sum;
        }
        public double TinhLuongTrungBinh()
        {
            double avg;
            int sum = 0;
            int count = 0;
            foreach (NhanVien a in dsNV)
            {
                sum += a.TinhLuong();
                count++;
            }
            avg = sum / count;
            return avg;
        }

    }
}
