using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xucxac
{
    // lop xuc xac
    public class xuc_xac
    {
        // truong: so mat cua xuc xac
        private int so_mat;

        // ham khoi tao de khoi tao so mat
        public xuc_xac(int so_mat)
        {
            if (so_mat < 1)
            {
                throw new ArgumentException("mot xuc xac phai co it nhat mot mat.");
            }
            this.so_mat = so_mat;
        }

        // phuong thuc: quay xuc xac
        public int quay()
        {
            Random random = new Random();
            return random.Next(1, so_mat + 1); // tao so ngau nhien tu 1 den so_mat
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so mat cua xuc xac:");

            // doc du lieu nguoi dung nhap vao
            if (int.TryParse(Console.ReadLine(), out int so_mat) && so_mat > 0)
            {
                try
                {
                    // tao mot doi tuong xuc xac
                    xuc_xac xucxac = new xuc_xac(so_mat);

                    // quay xuc xac va hien thi ket qua
                    Console.WriteLine($"dang quay xuc xac {so_mat} mat...");
                    int ket_qua = xucxac.quay();
                    Console.WriteLine($"ket qua: {ket_qua}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"loi: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("vui long nhap so nguyen duong hop le cho so mat.");
            }
        }
    }
}
