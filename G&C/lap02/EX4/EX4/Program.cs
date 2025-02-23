using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
}

//----------------------------------------------------------
// Các lớp IComparer để sắp xếp theo tiêu chí khác nhau
//----------------------------------------------------------
class CompareByAccountID : IComparer<Account>
{
    public int Compare(Account x, Account y) => x.AccountID.CompareTo(y.AccountID);
}

class CompareByFirstName : IComparer<Account>
{
    public int Compare(Account x, Account y) => x.FirstName.CompareTo(y.FirstName);
}

class CompareByBalance : IComparer<Account>
{
    public int Compare(Account x, Account y) => x.Balance.CompareTo(y.Balance);
}

//----------------------------------------------------------
// Lớp AccountList chứa danh sách các tài khoản ngân hàng
//----------------------------------------------------------
class AccountList
{
    private List<Account> accounts = new List<Account>();
    private string filePath = "accounts.json";

    public void NewAccount(Account account)
    {
        accounts.Add(account);
    }

    public void RemoveAccount(string accountID)
    {
        accounts.Sort(new CompareByAccountID());
        int index = accounts.BinarySearch(new Account(accountID, "", "", 0), new CompareByAccountID());
        if (index >= 0)
        {
            accounts.RemoveAt(index);
            Console.WriteLine("Account removed successfully.");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void SaveFile()
    {
        string json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void LoadFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            accounts = JsonSerializer.Deserialize<List<Account>>(json) ?? new List<Account>();
        }
    }

    public void Report()
    {
        foreach (var account in accounts)
        {
            account.DisplayInfo();
        }
    }

    public void SortAccounts(IComparer<Account> comparer)
    {
        accounts.Sort(comparer);
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
            Console.WriteLine("2. Xóa tài khoản");
            Console.WriteLine("3. Lưu danh sách tài khoản vào file");
            Console.WriteLine("4. Tải danh sách tài khoản từ file");
            Console.WriteLine("5. Hiển thị danh sách tài khoản");
            Console.WriteLine("6. Sắp xếp theo Account ID");
            Console.WriteLine("7. Sắp xếp theo First Name");
            Console.WriteLine("8. Sắp xếp theo Balance");
            Console.WriteLine("9. Thoát");
            Console.Write("Chọn một tùy chọn: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Account ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter Balance: ");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    accountList.NewAccount(new Account(id, firstName, lastName, balance));
                    break;
                case "2":
                    Console.Write("Enter Account ID to remove: ");
                    string removeID = Console.ReadLine();
                    accountList.RemoveAccount(removeID);
                    break;
                case "3":
                    accountList.SaveFile();
                    Console.WriteLine("Danh sách tài khoản đã được lưu vào file.");
                    break;
                case "4":
                    accountList.LoadFile();
                    Console.WriteLine("Danh sách tài khoản đã được tải từ file.");
                    break;
                case "5":
                    accountList.Report();
                    break;
                case "6":
                    accountList.SortAccounts(new CompareByAccountID());
                    Console.WriteLine("Danh sách đã được sắp xếp theo Account ID.");
                    break;
                case "7":
                    accountList.SortAccounts(new CompareByFirstName());
                    Console.WriteLine("Danh sách đã được sắp xếp theo First Name.");
                    break;
                case "8":
                    accountList.SortAccounts(new CompareByBalance());
                    Console.WriteLine("Danh sách đã được sắp xếp theo Balance.");
                    break;
                case "9":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
    }
}
