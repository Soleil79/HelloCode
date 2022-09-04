/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
using System;*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для нахождения суммы натуральных числел в промежутке от M до N");
        Console.WriteLine("Введите число М:");
        int m = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите число N:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Cумма натуральных чисел в промежутке от M до N: {WriteNumber(m,n)}");      

    }
    
    static int  WriteNumber(int a, int b, int sum = 0)
    {
        sum += a;
        if(a == b) return sum;
        return WriteNumber(a + 1, b, sum);
    }
    
}

