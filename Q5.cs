using System;
class Program
{
    static void Main()
    {
        string friend1 = "Ashwini";
        string friend2 = "Akanksha";
        string friend3 = "Kalyani";

        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);
    }

    static void GreetFriend(string friendName)
    {
        Console.WriteLine($"Hi {friendName}, my friend!");
    }
}

//OUTPUT
Hi Ashwini, my friend!
Hi Akanksha, my friend!
Hi Kalyani, my friend!