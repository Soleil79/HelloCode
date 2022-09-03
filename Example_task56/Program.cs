/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;
class Program
{
    static void Main()
    {
        int [,] matrix = new int [4,4];
        FillArray(matrix);
        Console.WriteLine("Задан следующий двумерный массив чисел: ");
        PrintArray(matrix);
        int [] array = new int [4];
        RowElementSum(matrix, array);
        int MinElementRow = 0;
        MinRowSearch(array, MinElementRow);
        



    }
    static void FillArray (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1,100);

            }
            Console.WriteLine();
        }
    }
    
    static void PrintArray (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write(matr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void RowElementSum (int [,] matr, int [] Array)
    {
       
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            int sum = 0;
        
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum += matr[i,j];
                Array[i] = sum;                                                
            }
            Console.WriteLine($"Сумма элементов строки {i+1} равна {sum}");                                           
        }
          
    }

    static void MinRowSearch (int [] arr, int MinRow)
    {
        int i = 0;
        int min = arr[i];
        while (i < arr.Length)
        {
            if ( arr[i] <= min) 
            {
                min = arr[i];
                MinRow = i;
                i++;
                MinRow++;
            }
            else i++;
            
        }
               
        Console.WriteLine($"Строка массива с наименьшей суммой элементов: {MinRow} строка");
    }
    
}

