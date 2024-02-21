using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNV nv1 = new QuanLyNV();
            int chon = 0;
            do
            {
                Console.WriteLine("***CHUONG TRINH QUAN LY NHAN VIEN***");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien");
                Console.WriteLine("2.Hien thi thong tin nhan vien");
                Console.WriteLine("3.Thong ke tong tien luong phai tra cho nhan vien");
                Console.WriteLine("4.Tinh tien luong thuc lanh trung binh");
                Console.WriteLine("0.Thoat chuong trinh");
                Console.WriteLine("------------------------------------");
                Console.Write("Ban chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv1.NhapDS();
                        break;
                    case 2:
                        nv1.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong phai tra:{nv1.TinhTongLuong():#,##0 vnd}");
                        break;
                    case 4:
                        Console.WriteLine($"Luong thuc lanh trung binh:{nv1.TinhLuongTrungBinh():#,##0 vnd}");
                        break;

                    case 0:
                        Console.WriteLine("Tam Biet.");
                        Console.ReadLine();
                        break;
                }


            } while (chon != 0);
        }
    }
}
