/* Задание 6. Напишите программу со статическим методом, 
 * аргументом которому передаётся двумерный целочисленный массив. 
 * У метода, кроме аргумента-массива, есть два неинициализированных аргумента. 
 * Результатом метод возвращает значение наибольшего элемента в массиве. 
 * Неинициализированным аргументам присваиваются индексы этого элемента */
using System;
class MethodsTaskSix
{
    static int GetMax(int[,] numbers, out int index1, out int index2)
    {
        index1 = 0; index2 = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                if (numbers[j, i] > numbers[index1, index2])
                    index1 = j; index2 = i;
            }
        }
        return numbers[index1, index2];
    }
    static void Main()
    {
        Console.Write("Введите количество строк в двумерном массиве: ");
        int lines = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов в двумерном массиве: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = new int[lines, column];
        for (int j = 0; j < lines; j++)
        {
            for (int i = 0; i < column; i++)
            {
                Console.Write("Введите ({0}, {1})-ый элемент массива: ", j + 1, i + 1);
                numbers[j, i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int MaxValue, index1, index2;
        MaxValue = GetMax(numbers, out index1, out index2);
        Console.WriteLine("Наибольшее значение массива: " + MaxValue);
        Console.WriteLine("Индексы элемента: " + index1 + 1 + ", " + index2 + 1);
        Console.WriteLine("Проверка: numbers[{0}, {1}] = {2}",
            index1, index2, numbers[index1, index2]);
    }
}