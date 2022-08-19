/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
using System;
class Program
{
    static double [] fillArray (double [] array)
    {
        for (int i = 0; i < array.Length; i++)
       {
            array[i] = new Random().Next(0,100); //можно задать любой диапазон чисел, напрмер от -100 до 100.
       }
        return array;
    }
    static void PrintArray (double [] array)
    {
        Console.WriteLine("Представлен следующий массив вещественных чисел:");
        Console.Write("[  ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine("]");
    }
    static double MaxNum (double [] array, double max)
    {

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;                 
    }

        static double MinNum (double [] array, double min)
    {

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;                 
    }

    static void Main ()
    {
        double [] newArray = new double [5];
        fillArray(newArray);
        PrintArray(newArray);
        double MaxNumber = MaxNum(newArray, newArray[0]);
        double MinNumber = MinNum(newArray, newArray[0]);
        Console.WriteLine($"Разность между максимальным и минимальным эллементами вещественного массива: {MaxNumber-MinNumber}");
    }
}
