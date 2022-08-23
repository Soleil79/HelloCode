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
        Console.Write("Задан массив [ ");
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


    static int [] AddElement (int [] array)
    {
        int N = array.Length;
        int pos = array[N/2];
       
        
        array = Array.Resize(ref array, array.Length + 1);
        array[array.Length / 2] = 1;
        
        return array;
    }

    static int [] MultipleNums (int [] array, int [] secondArray)
    {
        int N = array.Length;
        int j = 0;
        
        for (int i = 0; i < array.Length/2; i++)
        {
           secondArray [j] = array[i] * array[N-1];
            N--;
            j++;
        }
        return secondArray;
    }
    
    static void Main ()
    {
        Console.WriteLine("Введите количество эллементов массива: ");
        int arraylenth = Convert.ToInt32(Console.ReadLine());
        int [] newArray = new int [arraylenth];
        FillArray(newArray);
        PrintArray(newArray);
        int N = newArray.Length;
        int[] MultipleArray = new int [N/2];
            if (N % 2 != 0)
            {
             AddElement(MultipleArray);
            }

        MultipleNums(newArray, MultipleArray);
        Console.WriteLine(" ");
        PrintArray(MultipleArray);

    }
}