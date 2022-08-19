/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
using System;
class Program
{
    static int [] fillArray (int [] array)
    {
        for (int i = 0; i < array.Length; i++)
       {
            array[i] = new Random().Next(-100,100);
       }
        return array;
    }
    static void PrintArray (int [] array)
    {
        Console.WriteLine("Представлен следующий массив случайных чисел:");
        Console.Write("[  ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine("]");
    }
    static int SumOddNumbers (int [] array, int sum)
    {
        int i = 0;

        while (i < array.Length)
        {
            if (array[i] % 2 != 0)
            {
                sum += array[i];
            }
            i++;
        }

        return sum;           
    }

    static void Main ()
    {
        int [] newArray = new int [4];
        fillArray(newArray);
        PrintArray(newArray);
        int SumOdd = SumOddNumbers(newArray, 0);
        Console.WriteLine($"Сумма нечетных чисел в массиве: {SumOdd}");
    }
}
