/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string[] WeekDays = {"Понедельник","Вторник","Среда","Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите день недели");
for(int i = 0; i < WeekDays.Length; i++)
{
    Console.Write(i+1 + " - " + WeekDays[i] + ", ");
}
Console.WriteLine(" ");
int dayweek = Convert.ToInt32(Console.ReadLine());
              
if (dayweek == 6 || dayweek == 7)
{
    Console.WriteLine("да, " + dayweek + " - выходной день.");
}
else 
{
    Console.WriteLine("нет, " + dayweek + " - будний день.");
}