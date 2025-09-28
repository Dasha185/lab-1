using System;

namespace BankAccountTypes
{
    // Перечислимый тип для видов банковского счета
    enum AccountType
    {
        Current,    // Текущий счет
        Savings     // Сберегательный счет
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание переменной типа перечисления
            AccountType myAccountType;

            // Присвоение значения переменной
            myAccountType = AccountType.Savings;

            // Вывод значения на печать
            Console.WriteLine($"Тип банковского счета: {myAccountType}");

            // Дополнительные примеры для демонстрации
            Console.WriteLine($"Числовое значение: {(int)myAccountType}");

            // Пример с текущим счетом
            AccountType currentAccount = AccountType.Current;
            Console.WriteLine($"Другой тип счета: {currentAccount}");
            Console.WriteLine($"Числовое значение: {(int)currentAccount}");

            // Ожидание ввода пользователя перед закрытием консоли
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

