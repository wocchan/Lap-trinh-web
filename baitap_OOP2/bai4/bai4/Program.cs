using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }
        public string ChucVu { get; set; }
        public abstract double TinhLuong();
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            BangCap = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
            Console.WriteLine("Bang cap: {0}", BangCap);
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("Luong: {0}", TinhLuong());
        }
    }

    class NhaKhoaHoc : NhanVien
    {
        public int SoBaiBao { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap so bai bao da cong bo: ");
            SoBaiBao = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            BacLuong = double.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }

    class NhaQuanLy : NhanVien
    {
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            BacLuong = double.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }

    class NhanVienPTN : NhanVien
    {
        public double LuongThang { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap luong thang: ");
            LuongThang = double.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return LuongThang;
        }
    }

    class Program
    {
        static void Main()
        {
            List<NhanVien> danhSachNV = new List<NhanVien>();
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chon loai nhan vien (1: Nha Khoa Hoc, 2: Nha Quan Ly, 3: Nhan Vien PTN): ");
                int loai = int.Parse(Console.ReadLine());
                NhanVien nv;
                if (loai == 1) nv = new NhaKhoaHoc();
                else if (loai == 2) nv = new NhaQuanLy();
                else nv = new NhanVienPTN();

                nv.NhapThongTin();
                danhSachNV.Add(nv);
            }

            double tongLuongNhaKhoaHoc = 0, tongLuongNhaQuanLy = 0, tongLuongNVPTN = 0;
            Console.WriteLine("\n===== DANH SACH NHAN VIEN =====");
            foreach (var nv in danhSachNV)
            {
                nv.XuatThongTin();
                if (nv is NhaKhoaHoc) tongLuongNhaKhoaHoc += nv.TinhLuong();
                else if (nv is NhaQuanLy) tongLuongNhaQuanLy += nv.TinhLuong();
                else tongLuongNVPTN += nv.TinhLuong();
            }

            Console.WriteLine("\nTong luong nha khoa hoc: {0}", tongLuongNhaKhoaHoc);
            Console.WriteLine("Tong luong nha quan ly: {0}", tongLuongNhaQuanLy);
            Console.WriteLine("Tong luong nhan vien PTN: {0}", tongLuongNVPTN);
            Console.ReadLine();
        }
    }

}
