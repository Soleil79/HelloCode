/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (Здесь была ошибка в задании, 29 будет если m =3, n =2)
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("программа вычисления функции Аккермана с помощью рекурсии");
        Console.WriteLine("Введите неотрицательное число М:");
        int m = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите неотрицательное число N:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Функция Аккермана равна {Ackermann(m,n)}");      

    }
    
    static int Ackermann (int a, int b)
    {
        if(a == 0) return b + 1;
            else if (a > 0 && b == 0) return Ackermann(a-1, 1);
            else return Ackermann(a-1, Ackermann(a,b-1));
    }
    
}
