/* Задание 1. Напишите программу, в которой описан статический метод для
* вычисления двойного факториала числа, переданного аргументом методу.
* Предложите версию метода без рекурсии и с рекурсией */
using System;
class MethodsTaskOne
{
    static int DoubleFactorialWithRecourse(int n)
    {
        if (n == 1) return 1;
        else if (n == 2) return 2;
        else return n * DoubleFactorialWithRecourse(n - 2);
    }
    static int DoubleFactorialWithoutRecourse(int n)
    {
        int DoubleFactorial = n;
        for (int i = n - 2; i >= 1; i = i - 2)
        {
            DoubleFactorial *= i;
        }
        return DoubleFactorial;
    }
    static void Main()
    {
        Console.Write("Введите число для вычисления двойного факториала: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычисления двойного факториала числа " +
            n + " статическим методом с рекурсией: " +
            DoubleFactorialWithRecourse(n));
        Console.WriteLine("Результат вычисления двойного факториала числа " +
            n + " статическим методом без рекурсии: " +
            DoubleFactorialWithoutRecourse(n));
        Console.ReadKey();
    }
}