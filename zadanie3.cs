using System;

public enum University
{
    КГУ,
    КАИ,
    КХТИ
}

// Структура работник
public struct Employee
{
    public string Name;   
    public University University; 

    public void PrintEmployeeInfo()
    {
        Console.WriteLine("Информация о работнике:");
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"ВУЗ: {University}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee1;
        employee1.Name = "Иванов Алексей";
        employee1.University = University.КГУ;

        Employee employee2 = new Employee
        {
            Name = "Петрова Мария",
            University = University.КАИ
        };

        Employee employee3;
        employee3.Name = "Сидоров Дмитрий";
        employee3.University = University.КХТИ;

        employee1.PrintEmployeeInfo();
        employee2.PrintEmployeeInfo();
        employee3.PrintEmployeeInfo();
    } }