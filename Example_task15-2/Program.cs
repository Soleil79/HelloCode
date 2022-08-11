/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

class program
{
    static void Main(string[] args)
    {
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
   
        /*Dictionary<int, string> eve = new Dictionary<int, string>()
    {
        {1, "Понедельник, рабочий день"},
        {2, "Вторник, рабочий день"},
        {3, "Среда, рабочий день"},
        {4, "Четверг, рабочий день"},
        {5, "Пятница, рабочий день"},
        {6, "Суббота, рабочий день"},
        {7, "Воскресенье, рабочий день"},
    };
    int index = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(eve[index]);
    */
    }

}
