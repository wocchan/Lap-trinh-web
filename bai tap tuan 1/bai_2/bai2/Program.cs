using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PhuongTrinhBacHai
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap he so c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Day khong phai phuong trinh bac hai. He so 'a' phai khac 0.");
                Console.WriteLine("Nhan phim bat ky de ket thuc...");
                Console.ReadLine();
                return;
            }
            //tinh delta
            double delta = Math.Pow(b, 2) - 4 * a * c;

            //xet 
            if (delta > 0)
            {
                //hai nghiem phan biet
                double nghiem1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double nghiem2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                Console.WriteLine($"Nghiem 1 = {nghiem1}");
                Console.WriteLine($"Nghiem 2 = {nghiem2}");
            }
            else if (delta == 0)
            {
                //nghiem kep
                double nghiem = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep:");
                Console.WriteLine($"Nghiem = {nghiem}");
            }
            else
            {
                //nghiem phuc
                double phanThuc = -b / (2 * a);
                double phanAo = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem phuc:");
                Console.WriteLine($"Nghiem 1 = {phanThuc} + {phanAo}i");
                Console.WriteLine($"Nghiem 2 = {phanThuc} - {phanAo}i");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Vui long nhap gia tri so hop le!");
        }
        Console.WriteLine("Nhan phim bat ky de ket thuc...");
        Console.ReadLine();
    }
}
