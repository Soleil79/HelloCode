// Программа определения наибольшего и наименьшего целого числа из двух заданных.
int max;
int min;

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());;

if (a > b) 
{
    max = a; min = b;
}
else 
{
    max = b; min = a;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
