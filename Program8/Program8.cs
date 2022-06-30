/* Задание 8. Напишите программу с перегруженным статическим методом
* Если аргументом методу передаётся два целых числа, 
* то результатом возвращается ссылка на массив натуральных чисел, 
* первое и последнее число которого определяется аргументами метода.
* Если аргументами методу передаются два символьных значения, 
* то результатом возвращается ссылка на массив символов, 
* первый и последний символы определяются аргументами метода */
using System;
class MethodsTaskEight
{
    static int[] ShowArray(int a, int b)
    {
        int[] numbers = new int[b - a + 1];
        for (int i = a; i <= b; i++)
        {
            numbers[i - a] = i;
        }
        return numbers;
    }
    static char[] ShowArray(char a, char b)
    {
        char[] symbols = new char[(int)b - (int)a + 1];
        for (int i = (int)a; i <= (int)b; i++)
        {
            symbols[i - (int)a] = (char)i;
        }
        return symbols;
    }
    static void Main()
    {
        Console.WriteLine("Введите первую переменную: ");
        int aNumber = Convert.ToInt32(Console.ReadLine());
        char aSymbol = Convert.ToChar(aNumber);
        Console.WriteLine("Введите вторую переменную: ");
        int bNumber = Convert.ToInt32(Console.ReadLine());
        char bSymbol = Convert.ToChar(bNumber);
        Console.Write("Массив чисел: ");
        int[] numbers = ShowArray(aNumber, bNumber);
        for (int i = 0; i <= bNumber - aNumber; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Массив символов: ");
        char[] symbols = ShowArray(aSymbol, bSymbol);
        for (int i = 0; i <= bNumber - aNumber; i++)
        {
            Console.Write(symbols[i] + " ");
        }
        Console.WriteLine();
    }
}