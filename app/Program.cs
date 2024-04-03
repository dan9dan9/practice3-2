using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        Console.Write("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Сумма чисел: " + AddNumbers(num1, num2));
        //Console.WriteLine("Разность чисел: " + SubtractNumbers(num1, num2));
        //Console.WriteLine("Произведение чисел: " + MultiplyNumbers(num1, num2));
        //Console.WriteLine("Частное чисел: " + DivideNumbers(num1, num2));

        Console.ReadLine();
    }
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }
    static double SubtractNumbers(double a, double b)
    {
        return a - b;
    }
}
