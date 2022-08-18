/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

using System;

    class program
    {
        static void Main()
        {
          Console.WriteLine("Введите ряд чисел через запятую (без пробелов): ");
          string? numbers = Console.ReadLine();
          numbers = numbers + ",";
          string deleteSpaces = RemovingSpaces(numbers);
          string WhitoutCommas = WithoutCommas(deleteSpaces);
          int[] newArray = FillArray(WhitoutCommas);
          PrintArray(newArray);
        }
      

        static string RemovingSpaces (string nums) //Удаление пробелов из строки
        {
          string numsNew = "";
            for (int i = 0; i < nums.Length; i++)
            {
              if (nums[i] != ' ') 
              {
                numsNew += nums[i];
              }
            }
            return numsNew;
        }
          static string WithoutCommas (string onlynums)
        {
          
          int i = 0;
          string onlynums1 = ""; // кавычки, а не 0, потому что строка
          
              while (i < onlynums.Length) 
              {
                if (onlynums[i] != ',') 
                {                
                onlynums1 += onlynums[i];
                }
                i++;                               
              }                
            return onlynums1;
        }

          static int [] FillArray (string newArray) //Заполнение массива
          {
            int [] numsArray = new int[newArray.Length];
                for (int i = 0; i < newArray.Length; i++)
              {
                numsArray[i] = int.Parse(newArray[i].ToString());
              }
         
              return numsArray;
          }


/*
// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}*/
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

