/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine ("Введите число, которое хотите возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите степень, в которую будете возводить число: ");
int B = Convert.ToInt32(Console.ReadLine()); 

    Console.WriteLine(Math.Pow(A,B));


//возведение в нужную степень: Math.Pow(число, степень)