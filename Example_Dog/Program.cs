int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int Friend = 2;
int time;


while (distance > 10)
{
    if (Friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        Friend = 2; 
    }
    else
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }  
    
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
} 

Console.WriteLine($"Собака пробежит {count} раз");
