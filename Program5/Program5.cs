/* Задание 5. Напишите программу со статическим методом, 
* аргументом которому передаётся целочисленный массив, 
* а результатом возвращается среднее значение элементов массива */
using System;
class MethodsTaskFive
{
    static double CalcAverage(int[] numbers)
    {
        double average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        return average / numbers.Length;
    }
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введите {0}-ый элемент массива: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Среднее значение элементов массива: ",
            CalcAverage(numbers));
    }
}