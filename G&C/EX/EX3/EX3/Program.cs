using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class StudentCollection : CollectionBase
{
    public void Add(Student student)
    {
        List.Add(student);
    }

    public void Remove(Student student)
    {
        List.Remove(student);
    }

    public Student this[int index]
    {
        get { return (Student)List[index]; }
        set { List[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        StudentCollection students = new StudentCollection();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            students.Add(new Student { ID = id, Name = name, Age = age });
        }

        List<Student> sortedList = new List<Student>();
        foreach (Student student in students)
        {
            sortedList.Add(student);
        }

        sortedList.Sort(new StudentComparer());

        Console.WriteLine("Danh sach sinh vien sau khi sap xep theo ten:");
        foreach (Student student in sortedList)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}

class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
