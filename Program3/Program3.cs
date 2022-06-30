/* Задание 3. Напишите программу со статическим методом, 
 * которому аргументом передаётся целочисленный массив и целое число.
 * Результатом метод возвращает ссылку на новый массив, 
 * который получается из исходного массива, 
 * если в нём взять несколько начальных элементов. 
 * Количество элементов, которые нужно взять из исходного массива, 
 * определяется вторым аргументом метода.
 * Если второй аргумент метода больше длины массива, 
 * переданного первым аргументом, 
 * то методом создаётся копия исходного массива 
 * и возвращается ссылка на эту копию */
using System;
class MethodsTaskThree
{
    static int[] CreateNewArray(int[] numbers, int n)
    {
        int count;
        if (n <= numbers.Length) count = n;
        else count = numbers.Length;
        int[] NewArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            NewArray[i] = numbers[i];
        }
        return NewArray;
    }
    static void Main()
    {
        Console.Write("Введите количество элементов одномерного массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введите {0}-ый элемент массива: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nВведите натуральное число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] NewArray = CreateNewArray(numbers, n);
        for (int i = 0; i < NewArray.Length; i++)
        {
            Console.Write("{0}-ый элемент нового массива: ", i + 1);
            Console.WriteLine(NewArray[i]);
        }
    }
}