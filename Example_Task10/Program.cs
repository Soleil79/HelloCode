// 1 Вариант решения
/*Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 100; // первое число
int b = num % 100 / 10; // второе число
int c = num % 10; // третье число

Console.WriteLine ($"Вторая цифра числа {num}: "  + b);*/


// 2 Вариант
Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(num);

Console.WriteLine("вторая цифра этого числа: " + stringNum[1]);