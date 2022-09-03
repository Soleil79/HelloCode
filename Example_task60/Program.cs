/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/



using System;
class Program
{
    static void Main()
    {
                
        Console.WriteLine($"Введите размер трехмерного массива X x Y x Z:");
        Console.WriteLine("Введите Х:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Z:");
        int z = Convert.ToInt32(Console.ReadLine());
        int[,,] matrix3D = new int[x, y, z];                 
        FillArray3D(matrix3D);
        PrintArray3D(matrix3D);

        
        
    }
    static bool FindNum(int num, int [,,] matr)
    {
       bool res = false;
         for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    if (matr[i,j,k] == num) 
                    {
                        return true;
                    }  
                                                     
                    
                }
            }
        }
        return res;

    }

    static void FillArray3D (int [,,] NewArray)
    {
        for (int i = 0; i < NewArray.GetLength(0); i++)
        {
            for (int j = 0; j < NewArray.GetLength(1); j++)
            {
                int k = 0;
                while (k < NewArray.GetLength(2))
                {
                    int temp = new Random().Next(1,99);
                    
                    if (!FindNum(temp, NewArray))
                    {
                        NewArray[i,j,k] = temp;
                        k++;
                    }
                }                   
            }              
        }     
    }
    
    static void PrintArray3D (int [,,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                     Console.Write($"{matr[j, k, i]}({j},{k},{i}) ");
                }
                Console.WriteLine();
            }
        }
    }
}

