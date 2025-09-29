using System;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountType { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountNumber, string accountType, decimal balance)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        Balance = balance;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Счет: {AccountNumber}");
        Console.WriteLine($"Тип: {AccountType}");
        Console.WriteLine($"Баланс: {Balance:C}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта банковского счета
        BankAccount account = new BankAccount(
            "40817810099910004321",
            "Расчетный счет",
            150000.75m
        );

        // Вывод информации
        account.PrintInfo();

        Console.ReadLine();
    }
}
