using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{// lop truu tuong Shape
    abstract class shape
    {
        protected int x, y;

        public shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void diChuyen(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public abstract void hienThi();
        public abstract override string ToString();
    }

    // lop line ke thua shape
    class line : shape
    {
        private int x2, y2;

        public line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void hienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"duong thang: diem dau({x}, {y}), diem cuoi({x2}, {y2})";
        }
    }

    // lop circle ke thua shape
    class circle : shape
    {
        private int banKinh;

        public circle(int x, int y, int banKinh) : base(x, y)
        {
            this.banKinh = banKinh;
        }

        public override void hienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"hinh tron: tam({x}, {y}), ban kinh {banKinh}";
        }
    }

    // lop rectangle ke thua shape
    class rectangle : shape
    {
        private int x2, y2, x3, y3;

        public rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void hienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"hinh chu nhat: diem 1({x}, {y}), diem 2({x2}, {y2}), diem 3({x3}, {y3})";
        }
    }

    // lop polyline ke thua shape
    class polyline : shape
    {
        private List<(int, int)> diem;

        public polyline(int x, int y) : base(x, y)
        {
            diem = new List<(int, int)> { (x, y) };
        }

        public void themDiem(int x, int y)
        {
            diem.Add((x, y));
        }

        public override void hienThi()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"duong gap khuc: {string.Join(" -> ", diem)}";
        }
    }

    // chuong trinh chinh
    class program
    {
        static void Main()
        {
            shape duongThang = new line(0, 0, 10, 10);
            shape hinhTron = new circle(5, 5, 3);
            shape hinhChuNhat = new rectangle(0, 0, 4, 0, 4, 3);
            polyline duongGapKhuc = new polyline(1, 1);
            duongGapKhuc.themDiem(2, 3);
            duongGapKhuc.themDiem(5, 8);

            duongThang.hienThi();
            hinhTron.hienThi();
            hinhChuNhat.hienThi();
            duongGapKhuc.hienThi();
        }
    }

}
