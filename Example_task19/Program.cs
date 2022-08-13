/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

class program
{
    static void Main()
    {
        Console.WriteLine ("Введите число для определения является ли оно палиндромом: ");
        int num = Convert.ToInt32(Console.ReadLine()); //*см.Примечание зачем эта строка внизу страницы
        string stringNum1 = Convert.ToString(num); // Преобразовываем числовую переменную в текстовую
        char[] stringNum = stringNum1.ToCharArray(); //Расшиваем переменную в Char массив.
        int N = stringNum.Length-1;
        int i = 0; 
        int count = 0;       
    
      
        while (i < N)
        {
            if (stringNum[i] == stringNum[N])
            {  
                i++;
                N--;  
                count++;       
            }
            else
            {
                break;
            }  
            
           
        } 

    
        if (count == stringNum.Length/2)
        {
            Console.WriteLine("число " + num +" является палиндромом");
        }
        else
        {
            Console.WriteLine("число" + num +" не является палиндромом");
        }
       
    }
    
}

/*Примечание: Я попробовала переписать без промежуточной строки (int num = Convert.ToInt32(Console.ReadLine());) вот так:

string stringNum1 = Console.ReadLine(); 
char[] stringNum = stringNum1.ToCharArray(); 

Но появляются нижеследующие предупреждения в консоли:

C:\Users\user\Desktop\untitiled\hwork\task19\Program.cs(15,29): warning CS8600: Преобразование литерала, допускающего значение NULL  
или возможного значения NULL в тип, не допускающий значение NULL. [C:\Users\user\Desktop\untitiled\hwork\task19\task19.csproj]       
C:\Users\user\Desktop\untitiled\hwork\task19\Program.cs(16,28): warning CS8602: Разыменование вероятной пустой ссылки. [C:\Users\use 
r\Desktop\untitiled\hwork\task19\task19.csproj]*/
