using System;
using System.Threading;

namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Slayer! What's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Here is your Sword {playerName}! Now get out there and do what you do best!");// want to change the dialouge here (need more instructions)
            
            //declaring hp, mp, and dmg
            int HP = 100;
            int MP = 50;
            int swordDmg = 5;
            int swordAcc = 85;
            int punchDmg = 1;
            int punchAcc = 100;

            Console.ForegroundColor = ConsoleColor.Yellow; //need to change this up, doesn't change the rat color in later dialouge
            string rat = "Rat";
            Console.ResetColor();


            Console.WriteLine("");
            DisplayStats(HP, MP);

            Console.WriteLine("");
            Console.WriteLine("*You are faced with two doors, which do you choose?*");
            Console.WriteLine("");

            // First fork in the road
            Console.WriteLine("1 - Enter to follow the path of the Dragon   *COMBAT*");
            Console.WriteLine("2 - Enter to follow the path of the Lich Lord   *PUZZLES*");
            var firstChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch(firstChoice)
            {
                case 1:
                Console.WriteLine($"You enter the room, and are greeted by the {rat} holding a knife!");
                Console.WriteLine("");

                    int ratHP = 8;// declaring rat hp and dmg
                    int ratDMG = 4;
                    int ratAcc = 70;
                    
                    Console.WriteLine("Combat has been Initiated!!!");
                        
                        for (int i = 0; i < 15; i++) {
                            
                        if (ratHP > 0)
                        {
                            Console.WriteLine($"{15 - i} Rounds left in combat.");
                            Console.WriteLine("");
                            Console.WriteLine($"1 - Attack the {rat} with your Sword ");
                            Console.WriteLine($"2 - Punch the {rat}");
                            var ratCombat = int.Parse(Console.ReadLine());
                            switch (ratCombat)
                            {
                                case 1:
                                    //add random number generator to roll to hit
                                    if (HitRoll(0, 100) < swordAcc)
                                    {
                                        ratHP = ratHP - swordDmg;
                                        Console.WriteLine($"You Hit!!");
                                        Console.WriteLine($"You dealt {swordDmg} DMG!!");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You Missed!!");
                                    }
                                   
                                    break;
                                case 2:
                                    if (HitRoll(0, 100) < punchAcc)
                                    {
                                        ratHP = ratHP - punchDmg;
                                        Console.WriteLine($"You Hit!!");
                                        Console.WriteLine($"You dealt {punchDmg} DMG!!");
                                    }
                                    break;
                                default:
                                    //not sure what to put here
                                    break;
                            }
                            if (ratHP > 0)
                            {
                                if (HitRoll(0, 100) < ratAcc)
                                {
                                    HP = HP - ratDMG;
                                    Console.WriteLine($"The {rat} swings it's knife!");
                                    Console.WriteLine($"You took {ratDMG} DMG!");
                                } else
                                {
                                    Console.WriteLine("The Rat Missed");
                                }
                                
                            }
                            DisplayStats(HP, MP);
                        }
                        else {
                            Console.WriteLine("");
                            Console.WriteLine($"The {rat} has died!");

                            i = 15;
                        }
                    }//end of combat

                    break;
                case 2:
            
                Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");
                Console.WriteLine("");
                Console.WriteLine("1 - Investigate the noise");
                Console.WriteLine("2 - Head straight to the exit");
                var spoopy = int.Parse(Console.ReadLine());
                switch(spoopy)
                {
                    case 1:
                        Console.WriteLine($"{playerName}...... Why have you abandoned meeeee?....");
                        Console.WriteLine("You feel as if your soul is slowly being tugged out of you body *You lose 10 MP*");
                        Console.WriteLine("");

                        MP = MP - 10;
                            DisplayStats(HP, MP);
                            // Console.WriteLine("exit the room start next trial");
                            break;
                    case 2:
                        // Console.WriteLine("exit the room start next trial");
                        break;
                    default:
                        break;
                }
                    break;
                default:
                Console.WriteLine("You fall into a hidden pit and take 99 DMG");
                    Console.WriteLine("");
                HP = HP - 99;
                    DisplayStats(HP, MP);
                    // need to continue with something here
                    break;
            }

        }


        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }//end of random die roll


        public static void DisplayStats(int HP, int MP) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"HP: {HP}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"MP: {MP}");
            Console.ResetColor();
        }//end of display stats
    }
}
