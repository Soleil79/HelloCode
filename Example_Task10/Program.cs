﻿Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 100; // первое число
int b = num % 100 / 10; // второе число
int c = num % 10; // третье число

Console.WriteLine ($"Вторая цифра числа {num}: "  + b);


/*int a, b, c;
            for (int i = 100; i < 1000; i++)
            {
                a = i % 10;//находим первую цифру, остатком от деления(%)
                b = (i/10)%10;//находим среднюю цифру, остатком от деления(%) и целой частью от деления(/)
                c = i / 100;//находим последнюю цифру
                if (a + c == b) { Console.WriteLine(i); }//делаем проверку и выводим на экран
            }
*/