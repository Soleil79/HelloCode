/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using System;
class Program
{
    static void Main ()
    {
        int[] array = new int [0];
        /*while (true)
        {
            Console.WriteLine("Введите ряд чисел для заполнения массива ");
            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                int number = Convert.ToInt32(meaning);
                int[] newArray = array;
                array = new int[array.Length + 1];
                for(int i = 0; i < newArray.Length; i++)
                {
                    array[i] = newArray [i];
                }
                array[array.Length-1] = number;
            }
            else
            {
                break;
            }
           
        }*/
    
        FillArray(array);
        PrintArray(array);
        int PositiveCount = CountPositive(array, 0);
        Console.WriteLine(" ");
        Console.WriteLine($"Количество чисел больше нуля в массиве равно: {PositiveCount}");

    }


     static int [] FillArray (int [] numsarray)
    {
       
        while (true)
        {
                     
            for (int i = 0; i < numsarray.Length; i++)
            {
                Console.WriteLine("Введите отрицательные и положительные числа: ");
                numsarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numsarray;
        }
        
    }

    static void PrintArray (int[] coll) 
    {
        int i = 0;
        int N = coll.Length;
        Console.Write("[");
        
        while (i < N-1)
        {
        Console.Write($"{coll[i]},");
        i++;
        if ( i == N-1) Console.Write($"{coll[i]}");
        }        
        Console.Write("]");
    }   
      
    static int  CountPositive (int [] numArray, int count)
    {
        
        for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i] > 0) 
            {
                count++;
            }
        }
        return count;
    }

}


// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

/*Console.Clear();

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/