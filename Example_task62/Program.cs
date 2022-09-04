/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
using System;
class Program
{
    static void Main()
    {
        int n = 4;
        int m = 4;
        int [,] matrix = new int [n, m];
        FillArray(matrix);
        Console.WriteLine("Задан следующий массив: ");
        PrintArray(matrix);


      

    }
    static void FillArray (int [,] matr)
    {
        int i = 0;
        int j = 0;
        int firstnum = 01;
        while (firstnum <= matr.GetLength(0) * matr.GetLength(1))
        {
            matr[i, j] = firstnum;
            firstnum++;

            if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= matr.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > matr.GetLength(1) - 1)
                j--;
            else
                i--;
        }
    }
    
       static void PrintArray (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] >= 10)
                {
                    Console.Write(matr[i, j] + " ");
                }
                else
                {
                    Console.Write($"0{matr[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}


