/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

using System;
class Program
{
    static int [] fillArray (int [] array)
    {
        for (int i = 0; i < array.Length; i++)
       {
            array[i] = new Random().Next(-100,1000);
       }
        return array;
    }
    static void PrintArray (int [] array)
    {
        Console.WriteLine("Представлен следующий массив из 123 случайных чисел:");
        Console.Write("[  ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine("]");
    }
    static int numCount (int [] array, int count)
    {
        int i = 0;

        while (i < array.Length)
        {
            if (array[i] > 9 && array[i] < 100)
            {
                count ++;
                Console.WriteLine(array[i]);
            }
            i++;
        }

        return count;           
    }

    static void Main ()
    {
        int [] newArray = new int [123];
        fillArray(newArray);
        PrintArray(newArray);
        int numscount = numCount(newArray, 0);
        Console.WriteLine($"Количество эллементов, лежащих в отрезке [10,99] в массиве: {numscount}");
    }
}
