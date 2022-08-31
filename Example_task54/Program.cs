/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

using System;
class Program
{
    static void Main()
    {
        int m = 3;
        int n = 4;
        int [,] matrix = new int [m,n];
        FillArray(matrix);
        Console.WriteLine("Задан следующий двумерный массив чисел: ");
        PrintArray(matrix);
        //int [,] SortedMatrix = matrix;
        RowSorting(matrix);
        Console.WriteLine("Отсортированный массив: ");
        PrintArray(matrix);

      

    }
    static void FillArray (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1,10);

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
    static void  RowSorting (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++) 
        {                
            for (int j = 0; j < matr.GetLength(1); j++) 
            {
                for (int k = 0; k < matr.GetLength(1) - 1; k++)
                {
                    if (matr[i, k] < matr[i, k + 1])
                    {
                        int temp = matr[i, k + 1];
                        matr[i, k + 1] = matr[i, k];
                        matr[i, k] = temp;
                    }
                }   
               
            }
           
        }
        
    }
    
}


