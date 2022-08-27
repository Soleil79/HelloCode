/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

// индексы[1стр,1стлб] [1стр,2стлб]
//   table[0.0]   table[0,1]   table[0,2]    table[0,3]
//   table[1,0]   table[1,1]   table[1,2]    table[1,3]
// индексы[2стр,1стлб] [2стр,2стлб] 

using System;
class Program
{
    static void Main()
    {
        int [,] matrix = new int [5,5];
        int rowLentgh = matrix.GetLength(0);
        int columnLength = matrix.GetLength(1);
        FillArray(matrix);
        Console.WriteLine("Задан следующий двумерный массив чисел: ");
        PrintArray(matrix);

        Console.WriteLine("Введите порядковый номер элемента в строке массива: ");
        int row = Convert.ToInt32(Console.ReadLine())-1;
        Console.WriteLine("Введите порядковый номер элемента в столбце массива: ");
        int column = Convert.ToInt32(Console.ReadLine())-1;
        
        if (row < rowLentgh && column < columnLength)
        {
            FindPos(matrix, row, column);
        }

        else
        {
            Console.WriteLine($"Числа с заданными координатами ({row+1},{column+1}) не существует в данном массиве");
        }

    }
    static void FillArray (int [,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(0,100);

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
    
        static void FindPos (int [,] matr, int a, int b)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i,j] == matr[a,b])
                {
                    Console.Write($"Число, расположенное на заданных позициях в массиве равно: {matr[a, b]}");
                    
                }
                                
            }
        }
    }

}

