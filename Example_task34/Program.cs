/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using System;
class Program
{
    static int [] fillArray (int [] array)
    {
        for (int i = 0; i < array.Length; i++)
       {
            array[i] = new Random().Next(100,999);
       }
        return array;
    }
    static void PrintArray (int [] array)
    {
        Console.WriteLine("Представлен следующий массив трехзначных положительных чисел:");
        Console.Write("[  ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine("]");
    }
    static int EvenNumbers (int [] array, int count)
    {
        int i = 0;

        while (i < array.Length)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
            i++;
        }

        return count;           
    }

    static void Main ()
    {
        int [] newArray = new int [4];
        fillArray(newArray);
        PrintArray(newArray);
        int countEven = EvenNumbers(newArray, 0);
        Console.WriteLine($"Четных чисел в массиве: {countEven}");
    }
}
