using System;
using System.Collections.Generic;
using System.IO;

//----------------------------------------------------------
// Lớp Account chứa thông tin tài khoản ngân hàng
//----------------------------------------------------------
class Account
{
    public string AccountID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }

    public Account(string accountID, string firstName, string lastName, decimal balance)
    {
        AccountID = accountID;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account ID: {AccountID}, Name: {FirstName} {LastName}, Balance: {Balance:C}");
    }

    public static Account InputAccount()
    {
        Console.Write("Enter Account ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        return new Account(id, firstName, lastName, balance);
    }
}

//----------------------------------------------------------
// Lớp AccountList chứa danh sách các tài khoản ngân hàng
//----------------------------------------------------------
class AccountList
{
    private List<Account> accounts = new List<Account>();
    private string filePath = "accounts.txt";

    public void NewAccount()
    {
        Account account = Account.InputAccount();
        accounts.Add(account);
    }

    public void SaveFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var account in accounts)
            {
                writer.WriteLine($"{account.AccountID},{account.FirstName},{account.LastName},{account.Balance}");
            }
        }
    }

    public void LoadFile()
    {
        if (File.Exists(filePath))
        {
            accounts.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    accounts.Add(new Account(parts[0], parts[1], parts[2], decimal.Parse(parts[3])));
                }
            }
        }
    }

    public void Report()
    {
        foreach (var account in accounts)
        {
            account.DisplayInfo();
        }
    }
}

//----------------------------------------------------------
// Chương trình chính
//----------------------------------------------------------
class Program
{
    static void Main()
    {
        AccountList accountList = new AccountList();

        while (true)
        {
            Console.WriteLine("\n1. Thêm tài khoản mới");
            Console.WriteLine("2. Lưu danh sách tài khoản vào file");
            Console.WriteLine("3. Tải danh sách tài khoản từ file");
            Console.WriteLine("4. Hiển thị danh sách tài khoản");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn một tùy chọn: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    accountList.NewAccount();
                    break;
                case "2":
                    accountList.SaveFile();
                    Console.WriteLine("Danh sách tài khoản đã được lưu vào file.");
                    break;
                case "3":
                    accountList.LoadFile();
                    Console.WriteLine("Danh sách tài khoản đã được tải từ file.");
                    break;
                case "4":
                    accountList.Report();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }
}
