/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

// индексы[1стр,1стлб] [1стр,2стлб]
//   table[0,0]   table[0,1]   table[0,2]    table[0,3]
//   table[1,0]   table[1,1]   table[1,2]    table[1,3]
//   table[2,0]   table[2,1]   table[2,2]    table[2,3]
// индексы[2стр,1стлб] [2стр,2стлб] 

using System;
class Program
{
      static void Main ()
  {
    int m = 3;
    int n = 4;
    double [,] RandomMatr = new double[m,n];
    FillArray(RandomMatr);
    PrintArray(RandomMatr);
    ColumnAverage(RandomMatr, m, n);
  }

    static void FillArray (double [,] matr)
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
    
    static void PrintArray (double [,] matr)
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
    
       static void  ColumnAverage (double [,] matr, int rowlength, int columnlength)
    {
          Console.WriteLine("Среднее арифметическое: ");

        for (int i = 0; i < columnlength; i++) // здесь прогоняем по столбцам и их принимаем за i
        {
            double sum = 0;
            for (int j = 0; j < rowlength; j++) // здесь j- строки
            {
                sum += matr[j,i];                          
          
            }
            double average = Math.Round(sum / rowlength, 1);
            Console.WriteLine($"{i+1} столбца: {average}");
        }
        
    }

} 

