//Программа определения всех четных чисел от 1 до заданного пользователем числа N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int I = N - (N - 1);

while (I <= N)
{
    if (I % 2 == 0)
    {
        Console.WriteLine($"Четные числа: {I}");
    }
    I++; 
} 