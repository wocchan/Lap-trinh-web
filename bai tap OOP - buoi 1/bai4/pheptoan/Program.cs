using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pheptoan
{
    public class phan_so
    {
        public int tu_so { get; set; }
        public int mau_so { get; set; }

        public phan_so(int tu_so, int mau_so)
        {
            if (mau_so == 0)
            {
                throw new ArgumentException("mau so khong duoc bang 0.");
            }

            this.tu_so = tu_so;
            this.mau_so = mau_so;
            rut_gon();
        }

        // ham tinh uoc chung lon nhat
        private int ucln(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        // ham rut gon phan so
        private void rut_gon()
        {
            int uoc = ucln(tu_so, mau_so);
            tu_so /= uoc;
            mau_so /= uoc;

            if (mau_so < 0) // dam bao mau so luon duong
            {
                tu_so = -tu_so;
                mau_so = -mau_so;
            }
        }

        // cong hai phan so
        public phan_so cong(phan_so ps)
        {
            int tu = tu_so * ps.mau_so + ps.tu_so * mau_so;
            int mau = mau_so * ps.mau_so;
            return new phan_so(tu, mau);
        }

        // tru hai phan so
        public phan_so tru(phan_so ps)
        {
            int tu = tu_so * ps.mau_so - ps.tu_so * mau_so;
            int mau = mau_so * ps.mau_so;
            return new phan_so(tu, mau);
        }

        // nhan hai phan so
        public phan_so nhan(phan_so ps)
        {
            int tu = tu_so * ps.tu_so;
            int mau = mau_so * ps.mau_so;
            return new phan_so(tu, mau);
        }

        // chia hai phan so
        public phan_so chia(phan_so ps)
        {
            if (ps.tu_so == 0)
            {
                throw new ArgumentException("khong the chia cho phan so co tu so bang 0.");
            }

            int tu = tu_so * ps.mau_so;
            int mau = mau_so * ps.tu_so;
            return new phan_so(tu, mau);
        }

        // hien thi phan so
        public void hien_thi()
        {
            Console.WriteLine($"({tu_so}/{mau_so})");
        }

        // hien thi phan so dang so thap phan
        public void hien_thi_thap_phan()
        {
            Console.WriteLine($"{(double)tu_so / mau_so}");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("nhap phan so thu nhat (dinh dang: tu_so/mau_so):");
                string[] ps1_data = Console.ReadLine().Split('/');
                phan_so ps1 = new phan_so(int.Parse(ps1_data[0]), int.Parse(ps1_data[1]));

                Console.WriteLine("nhap phan so thu hai (dinh dang: tu_so/mau_so):");
                string[] ps2_data = Console.ReadLine().Split('/');
                phan_so ps2 = new phan_so(int.Parse(ps2_data[0]), int.Parse(ps2_data[1]));

                Console.WriteLine("ket qua cac phep toan:");

                phan_so tong = ps1.cong(ps2);
                Console.Write("cong: ");
                tong.hien_thi();

                phan_so hieu = ps1.tru(ps2);
                Console.Write("tru: ");
                hieu.hien_thi();

                phan_so tich = ps1.nhan(ps2);
                Console.Write("nhan: ");
                tich.hien_thi();

                phan_so thuong = ps1.chia(ps2);
                Console.Write("chia: ");
                thuong.hien_thi();

                Console.WriteLine("phan so thu nhat dang thap phan:");
                ps1.hien_thi_thap_phan();

                Console.WriteLine("phan so thu hai dang thap phan:");
                ps2.hien_thi_thap_phan();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"loi: {ex.Message}");
            }
        }
    }
}
