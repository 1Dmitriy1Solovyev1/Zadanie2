using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number > 5 && number < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка при вводе числа.");
        }
    }
}