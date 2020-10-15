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
            
            //declaring hp and mp
            int HP = 100;
            int MP = 50;
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("MP: " + MP);
            Console.WriteLine("*You are faced with two doors, which do you choose?*");

            // First fork in the road
            Console.WriteLine("1.Enter to follow the path of the Dragon   *COMBAT*");
            Console.WriteLine("2. Enter to follow the path of the Lich Lord   *PUZZLES*");
            var firstChoice = Console.ReadLine();

            if (firstChoice == "1")
            {
                Console.WriteLine("You enter the room, and are greeted by a Rat with a knife in it's mouth!");

            } else if (firstChoice == "2")
            {
                Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");

            }
            else
            {
                Console.WriteLine("*You found a Secret Room! You aren't supposed to be here!");
            }

        }
    }
}
