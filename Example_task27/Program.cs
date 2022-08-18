/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System; 
class Program
{
    static void Main()
    {
        Console.WriteLine ("Введите число");
        string number = Convert.ToString(Console.ReadLine());
        int [] array = new int[number.Length];
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            array[i] = int.Parse(number[i].ToString());
            sum = sum + array [i];
        }
        Console.WriteLine ($"Сумма цифр в числе {number} равна {sum}");
        
      
    }  
 
}



/*Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);*/