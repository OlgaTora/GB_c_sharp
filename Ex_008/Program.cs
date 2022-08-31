int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;
//вопрос про вычисление времени! в каких оно единицах и как ввести чило флоат
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count += 1;
}    
    Console.Write("Собака пробежит ");
    Console.Write(count);
    Console.Write(" раз");

