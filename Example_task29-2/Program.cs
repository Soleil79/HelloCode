using System;
class program
{
    static void Main (string[] args)
    {
        int[] array = new int [0];
        while (true)
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
        }
        PrintArray(array);
    }

    static void PrintArray (int[] coll) // вывод массива на печать
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
}
