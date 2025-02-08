using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01;

namespace Lab01
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() //Constructor mac dinh
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) //Constructor sao chep
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        //Constructor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        //Cac Property cho tung thuoc tinh cua lop
        public int StudentID //Property dai dien cho thuoc tinh SID
        {
            get { return SID; } //Lay du lieu
            set { SID = value; } //Gan du lieu
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        //Phuong thuc hien thi du lieu
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa:{0}", this.Khoa);
        }
    }
}
class Tester
{
    public static void Main()
    {
        Student[] DSSV;
        int n;
        Console.Write("Nhap so luong SV:");
        n = int.Parse(Console.ReadLine());
        DSSV = new Student[n]; //tao mang n phan tu
        Console.WriteLine("\n ====NHAP DS SINH VIEN====");
        for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
        {
            DSSV[i] = new Student();
            Console.Write("Nhap MaSV {0}:", i + 1);
            DSSV[i].StudentID = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV:");
            DSSV[i].Name = Console.ReadLine();
            Console.Write("Nhap khoa:");
            DSSV[i].Faculty = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            DSSV[i].Mark = float.Parse(Console.ReadLine());
        }
        //Xuat DS Sinh vien
        Console.WriteLine("\n ====XUAT DS SINH VIEN====");
        foreach (Student sv in DSSV)
            sv.Show();
        Console.ReadLine();
    }
}

