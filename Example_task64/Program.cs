/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для вывода натуральных числел в промежутке от M до N");
        Console.WriteLine("Введите число М:");
        int m = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите число N:");
        int n = Convert.ToInt32(Console.ReadLine());
        WriteNumber(m,n);      

    }
    
    static int  WriteNumber(int a, int b)
    {
        Console.Write(a + " ");
        if(a == b) return b;
        return WriteNumber(a + 1, b);
    }
    
}


