using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер месяца: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("Январь. 31 День ");
        }
        if (a == 2)
        {
            Console.WriteLine("Февраль. 28 Дней ");

        }
        if (a == 3)
        {
            Console.WriteLine("Март. 31 День ");
        }
        if (a == 4)
        {
            Console.WriteLine("Апрель. 30 Дней ");
        }
        if (a == 5)
        {
            Console.WriteLine("Май. 31 День ");
        }
        if (a == 6)
        {
            Console.WriteLine("Июнь. 30 Дней ");
        }
        if (a == 7)
        {
            Console.WriteLine("Июль. 31 День ");
        }
        if (a == 8)
        {
            Console.WriteLine("Август. 31 День ");
        }
        if (a == 9)
        {
            Console.WriteLine("Сентябрь. 30 Дней ");
        }
        if (a == 10)
        {
            Console.WriteLine("Октябпь. 31 День ");
        }
        if (a == 11)
        {
            Console.WriteLine("Ноябрь. 30 Дней ");
        }
        if (a == 12)
        {
            Console.WriteLine("Декабрь. 31 День ");
        }
        if (a > 12)
        {
            Console.WriteLine("Неверный номер месяца ");
        }
    }
}