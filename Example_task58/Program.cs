/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Для перемножение матриц должно выполнятся условие: количество столбцов первой матрицы должно быть равно количеству строк второй.
Искомая матрица будет иметь столько же строк, сколько в первой матрице, и столько же столбцов, сколько во второй матрице. В нашем случае 2 строки и 2 столбца.
Операция умножения двух матриц А и В представляет собой вычисление результирующей матрицы С, 
каждый элемент Сij которой равен сумме произведений элементов в соответствующей строке первой матрицы Аik и элементов в столбце второй матрицы Вkj.
*/

using System;
class Program
{
    static void Main()
    {
        int [,] matrix1 = {};
        FillArray(matrix1);
        Console.WriteLine("Задан первый двумерный массив чисел: ");
        PrintArray(matrix1);
        int [,] matrix2 = new int [2,2];
        FillArray(matrix2);
        Console.WriteLine("Задан второй двумерный массив чисел: ");
        PrintArray(matrix2);
        int [,] NewMatrix = new int [2,2];
        MultipleMatrixes(matrix1, matrix2, NewMatrix);
        Console.WriteLine("Произведение двух заданных матриц, представленное в виде результирующей матрицы: ");
        PrintArray(NewMatrix);
        
        
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

    static void MultipleMatrixes (int [,] matr1, int [,] matr2, int [,] newMatr)
    {
        for (int i = 0; i < newMatr.GetLength(0); i++) 
        {                
            for (int j = 0; j < newMatr.GetLength(1); j++) 
            {
                int sum = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    sum += matr1[i,k] * matr2[k,j];
                   
                }   
               newMatr[i,j] = sum;
            }
           
        }
        
    }
    
    
 
}

