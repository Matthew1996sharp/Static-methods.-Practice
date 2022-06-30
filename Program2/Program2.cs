/* Задание 2. Напишите программу со статическим методом,
 * которым вычисляется сумма квадратов натуральных чисел.
 * Предложите версию метода с рекурсией и без рекурсией */
using System;
class MethodsTaskTwo
{
    static int SummOfSquaresWithRecourse(int n)
    {
        if (n == 1) return n * n;
        else return n * n + SummOfSquaresWithRecourse(n - 1);
    }
    static int SummOfSquaresWithoutRecourse(int n)
    {
        int SummOfSquares = 0;
        for (int i = 1; i <= n; i++)
        {
            SummOfSquares += i * i;
        }
        return SummOfSquares;
    }
    static void Main()
    {
        Console.Write("Введите натуральное число для вычисления суммы квадратов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма квадратов натуральных чисел от 1 до "
            + n + " (без рекурсии) равна " + SummOfSquaresWithoutRecourse(n));
        Console.WriteLine("Сумма квадратов натуральных чисел от 1 до "
            + n + " (с рекурсией) равна " + SummOfSquaresWithRecourse(n));
        Console.WriteLine("Проверка расчётов: " + n * (n + 1) * (2 * n + 1) / 6);
        Console.ReadKey();
    }
}