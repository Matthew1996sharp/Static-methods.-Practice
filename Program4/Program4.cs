/* Задание 4. Напишите программу со статическим методом, 
* аргументом которому передаётся символьный массив, 
* а результатом возвращается ссылка на целочисленный массив, 
* сотоящий из кодов символов из массива-аргумента */
using System;
class MethodsTaskFour
{
    static int[] SymbolCodes(char[] symbols)
    {
        int[] codes = new int[symbols.Length];
        for (int i = 0; i < codes.Length; i++)
        {
            codes[i] = (int)symbols[i];
        }
        return codes;
    }
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве символов: ");
        int size = Convert.ToInt32(Console.ReadLine());
        char[] symbols = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введите {0}-ый элемент массива: ");
            symbols[i] = Convert.ToChar(Console.ReadLine());
        }
        int[] codes = SymbolCodes(symbols);
        for (int i = 0; i < size; i++)
        {
            Console.Write("{0}-ый элемент нового массива: ", i);
            Console.WriteLine(codes[i]);
        }
    }
}