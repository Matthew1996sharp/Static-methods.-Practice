/* Задание 9. Напишите программу со статическим методом, аргументом 
 * которому передаётся произвольное количество целочисленных аргументов.
 * Результатом метод возвращает массив из двух элементов:
 * наибольшее и наименьшее значения аргументов, переданных методу */
using System;
class MethodsTaskNine
{
    static int sum(params int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Сумма чисел: " + sum(1, 2, 3, 4));
    }
}