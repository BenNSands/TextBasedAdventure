using System;

namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Slayer! What's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine("Here is your Sword " + playerName + "! Now get out there and do what you do best!");
            int HP = 100;
            int MP = 50;
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("MP: " + MP);

        }
    }
}
