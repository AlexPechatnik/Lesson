int distance = 10000, firstFriendSpeed = 1,
secondFriendSpeed = 2, dogSpeed = 5,
friend = 2, count = 0;

while (count < 10)
{
    if (friend == 1)
    {
        int time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }

    if (friend == 2)
    {
        int time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}
Console.Write("count = ");
Console.WriteLine(count);