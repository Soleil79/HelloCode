using System;
int[,] matrix = { {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,1,0,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0}};
int row =  3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    matrix[row,column] = 0;
    oldRow = row;
    oldColumn = column;
    if(key.Key == ConsoleKey.W) row--; // можно не стрелки, а клавиши W
    if(key.Key == ConsoleKey.S) row++; //S
    if(key.Key == ConsoleKey.A) column--; //A
    if(key.Key == ConsoleKey.D) column++; //D

    if(row > matrix.GetLength(0)-1) row = matrix.GetLength(0)-1;
    if(row < 0) row = 0;
    
    if(column > matrix.GetLength(1)-1) column = matrix.GetLength(1)-1;
    if(column < 0) column = 0;
     matrix[row,column] = 1;
     WriteMatrix(matrix);
}
static void WriteMatrix(int[,] matrix)
{
    Console.Clear();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}