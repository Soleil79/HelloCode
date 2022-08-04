// Программа определения наибольшего целого числа из трех заданных.

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());


int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
