/* Задание 7. Напишите программу со статическим методом, 
 * аргументом которому передаётся одномерный символьный массив. 
 * В результате вызова метода элементы массива попарно меняются местами: 
 * первый - с последним, второй - с предпоследним и так далее */
using System;
class MethodsTaskSeven
{
    static char[] ArrayReplace(char[] SymbolsOld)
    {
        char[] SymbolsNew = new char[SymbolsOld.Length];
        for (int i = 0; i < SymbolsNew.Length; i++)
        {
            SymbolsNew[i] = SymbolsOld[SymbolsOld.Length - i - 1];
        }
        return SymbolsNew;
    }
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int size = Convert.ToInt32(Console.ReadLine());
        char[] SymbolsOld = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введите {0}-ый элемент массива: ", i + 1);
            SymbolsOld[i] = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine("Массив символов после преобразования:");
        char[] SymbolsNew = ArrayReplace(SymbolsOld);
        for (int i = 0; i < size; i++)
        {
            Console.Write(SymbolsNew[i] + " ");
        }
        Console.WriteLine();
    }
}