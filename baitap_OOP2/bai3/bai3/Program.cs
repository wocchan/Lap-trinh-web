using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class People
    {
        public int SID { get; set; }
        public string TenSV { get; set; }

        public People(int id, string ten)
        {
            SID = id;
            TenSV = ten;
        }
    }

    class Student : People
    {
        public string Khoa { get; set; }
        public float DiemTB { get; set; }

        public Student(int id, string ten, string khoa, float diemTB) : base(id, ten)
        {
            Khoa = khoa;
            DiemTB = diemTB;
        }

        public void HienThi()
        {
            Console.WriteLine($"Ma SV: {SID}, Ten: {TenSV}, Khoa: {Khoa}, Diem TB: {DiemTB}");
        }
    }

    class Tester
    {
        public static Student Nhap1SV()
        {
            int maSV;
            float diemTB;
            Console.Write("Ma SV: ");
            while (!int.TryParse(Console.ReadLine(), out maSV))
            {
                Console.Write("Nhap lai Ma SV: ");
            }

            Console.Write("Ten: ");
            string ten = Console.ReadLine();

            Console.Write("Khoa: ");
            string khoa = Console.ReadLine();

            Console.Write("Diem TB: ");
            while (!float.TryParse(Console.ReadLine(), out diemTB) || diemTB < 0 || diemTB > 10)
            {
                Console.Write("Nhap lai Diem TB: ");
            }

            Student student = new Student(maSV, ten, khoa, diemTB);
            Console.WriteLine("\nThong tin sinh vien vua nhap:\n");
            student.HienThi();
            return student;
        }

        public static ArrayList NhapDS()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhap lai so luong sinh vien: ");
            }

            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thong tin sinh vien {i + 1}:");
                students.Add(Nhap1SV());
            }
            return students;
        }

        public static void XuatDS(ArrayList students)
        {
            Console.WriteLine("\nDanh sach sinh vien:\n");
            foreach (Student student in students)
            {
                student.HienThi();
            }
        }

        public static void Main()
        {
            ArrayList students = NhapDS();
            XuatDS(students);
            Console.ReadLine(); //giu man hinh console
        }
    }
}
