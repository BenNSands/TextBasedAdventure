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
            ConsoleColor forground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HP: " + HP);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MP: " + MP);
            Console.ResetColor();

            Console.WriteLine("");
            Console.WriteLine("*You are faced with two doors, which do you choose?*");

            // First fork in the road
            Console.WriteLine("1 - Enter to follow the path of the Dragon   *COMBAT*");
            Console.WriteLine("2 - Enter to follow the path of the Lich Lord   *PUZZLES*");
            var firstChoice = Console.ReadLine();

            switch(firstChoice)
            {
                case "1":
                Console.WriteLine("You enter the room, and are greeted by a Rat holding a knife!");
                Console.WriteLine("");
                Console.WriteLine("1 - Attack the Rat with your Sword ");
                Console.WriteLine("2 - Punch the Rat");
                Console.WriteLine("3 - Run for the exit");
                var ratChoice = Console.ReadLine();
                    //insert if or switch statement here
                    break;
                case "2":
            
                Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");
                Console.WriteLine("");
                Console.WriteLine("1 - Investigate the noise");
                Console.WriteLine("2 - Head straight to the exit");
                var spoopy = Console.ReadLine();
                switch(spoopy)
                {
                    case "1":
                        Console.WriteLine($"{playerName}...... Why have you abandoned meeeee?....");
                        Console.WriteLine("You feel as if your soul is slowly being tugged out of you body *You lose 10 MP*");
                        MP = MP - 10;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HP: " + HP);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("MP: " + MP);
                        Console.ResetColor();
                        // Console.WriteLine("exit the room start next trial");
                        break;
                    case "2":
                        // Console.WriteLine("exit the room start next trial");
                        break;
                    default:
                        break;
                }
                    break;
                default:
                Console.WriteLine("You fall into a hidden pit and take 99 DMG");
                HP = HP - 99;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"HP: {HP}");
                Console.ResetColor();
                    // need to continue with something here
                    break;
            }

        }
    }
}
