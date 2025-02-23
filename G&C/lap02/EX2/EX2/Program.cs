using System;
using System.Collections.Generic;

//----------------------------------------------------------
// Interface mô tả các thuộc tính và phương thức cần thiết
//----------------------------------------------------------
interface IBook
{
    string Title { get; set; }
    string Author { get; set; }
    string Publisher { get; set; }
    int Year { get; set; }
    string ISBN { get; set; }
    List<string> Chapters { get; set; }
    void DisplayInfo();
}

//----------------------------------------------------------
// Lớp Book kế thừa từ IBook và thực thi các chi tiết
//----------------------------------------------------------
class Book : IBook, IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }
    public List<string> Chapters { get; set; }

    public Book(string title, string author, string publisher, int year, string isbn, List<string> chapters)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Year = year;
        ISBN = isbn;
        Chapters = chapters;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {Year}, ISBN: {ISBN}");
    }

    public int CompareTo(Book other)
    {
        return Title.CompareTo(other.Title); // Sắp xếp mặc định theo tên sách
    }
}

//----------------------------------------------------------
// Lớp BookList quản lý danh sách sách
//----------------------------------------------------------
class BookList
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }

    public void SortBooks(IComparer<Book> comparer)
    {
        books.Sort(comparer);
    }
}

//----------------------------------------------------------
// Các lớp so sánh sách theo tiêu chí khác nhau
//----------------------------------------------------------
class CompareByAuthor : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Author.CompareTo(y.Author);
    }
}

class CompareByYear : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Year.CompareTo(y.Year);
    }
}

class CompareByPublisher : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Publisher.CompareTo(y.Publisher);
    }
}

class CompareByTitle : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Title.CompareTo(y.Title);
    }
}

//----------------------------------------------------------
// Chương trình chính
//----------------------------------------------------------
class Program
{
    static void Main()
    {
        BookList bookList = new BookList();

        // Nhập danh sách sách
        bookList.AddBook(new Book("C# Basics", "John Doe", "Tech Books", 2020, "123-4567890123", new List<string> { "Intro", "Advanced" }));
        bookList.AddBook(new Book("Data Structures", "Alice Smith", "CS Press", 2018, "987-6543210987", new List<string> { "Arrays", "Trees" }));
        bookList.AddBook(new Book("AI Revolution", "Bob Johnson", "Future Press", 2022, "321-9876543210", new List<string> { "History", "Neural Networks" }));

        Console.WriteLine("Danh sách sách ban đầu:");
        bookList.DisplayBooks();

        Console.WriteLine("\nSắp xếp theo tác giả:");
        bookList.SortBooks(new CompareByAuthor());
        bookList.DisplayBooks();

        Console.WriteLine("\nSắp xếp theo tên sách:");
        bookList.SortBooks(new CompareByTitle());
        bookList.DisplayBooks();

        Console.WriteLine("\nSắp xếp theo năm xuất bản:");
        bookList.SortBooks(new CompareByYear());
        bookList.DisplayBooks();

        Console.WriteLine("\nSắp xếp theo nhà xuất bản:");
        bookList.SortBooks(new CompareByPublisher());
        bookList.DisplayBooks();
    }
}
