using System;

namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Slayer! What's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine("Here is your " + playerName + " Sword! Now get out there and do what you do best!");
        }
    }
}
