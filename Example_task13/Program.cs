/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine()); 

int a = Math.Abs(num);
string stringNum = Convert.ToString(a); // Преобразовываем числовую переменную в текстовую, где каждая цифра становится отдельныv элементом типа string



if (stringNum.Length < 3 )
{
    Console.WriteLine ("третьей цифры нет");
}
else 
{
    Console.WriteLine("третья цифра этого числа: "+stringNum[2]);
}
