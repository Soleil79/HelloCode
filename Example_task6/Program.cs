//Программа для определения того, является ли заданное число четным или нечетным.

Console.WriteLine("Проверим является ли четным число (да/нет)?");
String answer = Console.ReadLine();
while (answer.ToLower() == "да")
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine($"Да, {num} - четное число");
    }
    else
    {
        Console.WriteLine($"Нет, {num} - нечетное число");
    }
    Console.WriteLine("Проверим является ли четным число (да/нет)?");
    String answer_no = Console.ReadLine();
    if(answer_no.ToLower() == "нет") break;
} 