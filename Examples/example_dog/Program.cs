int count = 0;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
for (int distance = 20010; distance > 3; count++) 
{
    if (friend == 1) 
    {
        int time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }
    else
    {
        int time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;         
    }
}
System.Console.WriteLine($"Cобака пробежит {count} раз");