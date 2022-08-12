/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine ($"Введите координаты точки А (X, Y, Z)");
int XA = Convert.ToInt32(Console.ReadLine());
int YA = Convert.ToInt32(Console.ReadLine());
int ZA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine ($"Введите координаты точки B (X, Y, Z)");
int XB = Convert.ToInt32(Console.ReadLine());
int YB = Convert.ToInt32(Console.ReadLine());
int ZB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Abs (Math.Sqrt(Math.Pow((XB-XA),2) + Math.Pow((YB-YA),2) + Math.Pow((ZB-ZA),2)));

Console.WriteLine ($"Расстояние между точкой А и Точкой В равно: {Math.Round (distance,2)}");

//Math.Abs - модуль числа
//Math.Sqrt - квадратный корень числа
//Math.Pow - возведение числа в степень (число, степень)
//Math.Round - округление числа до нужного количества знаков после запятой (число, количество знаков)