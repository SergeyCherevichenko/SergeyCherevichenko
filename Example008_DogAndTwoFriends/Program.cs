int count = 0;
double distance  = 20;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend = 1;
double time;
while (distance > 10 )
{
    if (friend == 1)
    {
        time = distance / (dogSpeed - firstFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (secondFriendSpeed - firstFriendSpeed) * time;
    count = count +1;
}
Console.WriteLine("Собака пробежала " + count);
