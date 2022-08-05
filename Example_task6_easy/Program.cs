//Программа для определения того, является ли заданное число четным или нечетным.

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
