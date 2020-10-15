using System;

namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Slayer! What's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Here is your Sword {playerName}! Now get out there and do what you do best!");// want to change the dialouge here (need more instructions)
            
            //declaring hp and mp
            int HP = 100;
            int MP = 50;
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("MP: " + MP);
            Console.WriteLine("*You are faced with two doors, which do you choose?*");

            // First fork in the road
            Console.WriteLine("1 - Enter to follow the path of the Dragon   *COMBAT*");
            Console.WriteLine("2 - Enter to follow the path of the Lich Lord   *PUZZLES*");
            var firstChoice = Console.ReadLine();

            if (firstChoice == "1")
            {
                Console.WriteLine("You enter the room, and are greeted by a Rat holding a knife!");
                Console.WriteLine("");
                Console.WriteLine("1 - Attack the Rat with your Sword ");
                Console.WriteLine("2 - Punch the Rat");
                var ratChoice = Console.ReadLine();
                //if or switch statement here

            } else if (firstChoice == "2")
            {
                Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");
                Console.WriteLine("");
                Console.WriteLine("1 - Investigate the noise");
                Console.WriteLine("2 - Head straight to the exit");
                var spooopy = Console.ReadLine();
                switch(spooopy)
                {
                    case "1":
                        Console.WriteLine($"{playerName}...... Why have you abandon meeeee....");
                        Console.WriteLine("You feel as if your soul is slowly being tugged out of you body *You lose 10 MP*");
                        MP = MP - 10;
                        break;
                    case "2":
                        // ;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("You fall into a hidden pit and take 99 DMG");
                HP = HP - 99;
                Console.WriteLine($"HP: {HP}");
                // need to continue with something here
            }

        }
    }
}
