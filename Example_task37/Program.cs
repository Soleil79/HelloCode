/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

using System;
class Program
{
    static int [] FillArray (int[] numsarray)
    {
        
        while (true)
        {
            for (int i = 0; i < numsarray.Length; i++)
            {
                Console.WriteLine("Введите число: ");
                numsarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numsarray;
        }
    }

    static void PrintArray (int[] coll)
    {  
        int i= 0;
        int N = coll.Length;
        Console.Write("[ ");
        while (i < N)
        {
            if (i==N-1) 
            {
                Console.Write($"{coll[i]} ]");
            }
            else
            {
                Console.Write($"{coll[i]}, ");
            }
            i++;            
        }

    }


     static int [] MultipleNums (int [] array, int [] secondArray)
    {
        int N = array.Length;
        int i = 0;
        
        while (i < N)
        {
        if (i != N-1)
        {
           secondArray [i] = array[i] * array[N-1];
            N--;
            i++;
        }
        else
        {
            secondArray [i] = array[i] * 1;
            break;
        }
     
        }   return secondArray;
    }
    
    static void Main ()
    {
        Console.WriteLine("Введите количество эллементов массива: ");
        int arraylenth = Convert.ToInt32(Console.ReadLine());
        int [] newArray = new int [arraylenth];
        FillArray(newArray);
        Console.WriteLine($"Задан массив");
        PrintArray(newArray);
        int N = newArray.Length;
        if (N %  2 != 0)
        {
            int[] MultipleArray = new int [N/2+1];
            MultipleNums(newArray, MultipleArray);
            Console.WriteLine(" ");
            Console.WriteLine($"Новый массив, полученный из произведений противоположных элементов массива, заданного ранее: ");
            PrintArray(MultipleArray);
        }
        else
        {
            int[] MultipleArray = new int [N/2];
            MultipleNums(newArray, MultipleArray);
            Console.WriteLine(" ");
            Console.WriteLine($"Новый массив, полученный из произведений противоположных элементов массива, заданного ранее: ");
            PrintArray(MultipleArray);
        }

    }
}