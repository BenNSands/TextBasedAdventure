using System;
using System.Threading;

namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adventurer! What's your name?");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Here is your Sword {playerName}! Now get out there and find some Treasure!");// want to change the dialouge here (need more instructions)
            
            //declaring hp, mp, and dmg
            int HP = 100;
            int MP = 50;
            int swordDmg = 5;
            int swordAcc = 85;
            int punchDmg = 1;
            int punchAcc = 100;

            //NPC's declared here
            string ratName = "Rat";


            Console.WriteLine();
            DisplayStats(HP, MP);

            Console.WriteLine();
            Console.WriteLine("*You are faced with two doors, which do you choose?*");
            Console.WriteLine();

            // First fork in the road
            Console.WriteLine("1 - Enter to follow the path of the Dragon   *COMBAT*");
            Console.WriteLine("2 - Enter to follow the path of the Lich Lord   *PUZZLES*");
            var firstChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(firstChoice)// First Split
            {       //start if the combat line
                case 1:
                    Console.Write($"You enter the room, and are greeted by the ");
                    npcNames(ratName);
                    Console.Write(" holding a Knife!");

                Console.WriteLine();
                    
                    int ratHP = 8;// declaring rat hp and dmg
                    int ratDMG = 4;
                    int ratAcc = 70;
                    
                    Console.WriteLine("Combat has been Initiated!!!");
                        
                        for (int i = 0; i < 15; i++) {
                            
                        if (ratHP > 0)
                        {
                            Console.WriteLine($"{15 - i} Rounds left in combat.");
                            Console.WriteLine();
                            Console.Write("1 - Attack the ");
                            npcNames(ratName);
                            Console.WriteLine(" with your Sword");

                            Console.WriteLine();

                            Console.Write($"2 - Punch the ");
                            npcNames(ratName);

                            Console.WriteLine();
                            var ratCombat = int.Parse(Console.ReadLine());
                            switch (ratCombat)
                            {
                                case 1:
                                    
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
                                    Console.Write("The ");
                                    npcNames(ratName);
                                    Console.Write(" swings it's knife!");
                                    Console.WriteLine($"You took {ratDMG} DMG!");
                                } 
                                else
                                {
                                    Console.WriteLine("The Rat Missed");
                                }
                                
                            }
                            DisplayStats(HP, MP);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("The ");
                            npcNames(ratName);
                            Console.Write(" has died!");

                            i = 15;
                        }
                    }//end of combat
                    Console.WriteLine();
                    break;



                    //start of puzzle line
                case 2:
            
                Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");
                Console.WriteLine();
                Console.WriteLine("1 - Investigate the noise");
                Console.WriteLine("2 - Head straight to the exit");
                var spoopy = int.Parse(Console.ReadLine());
                switch(spoopy)
                {
                    case 1:
                        Console.WriteLine($"{playerName}...... Why have you abandoned meeeee?....");
                        Console.WriteLine("You feel as if your soul is slowly being tugged out of you body *You lose 10 MP*");
                        Console.WriteLine();

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
                    Console.WriteLine();
                HP = HP - 99;
                    DisplayStats(HP, MP);
                    // need to continue with something here
                    break;
            }
            //end of first challenges

        }//end of main

        public static void npcNames(string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.Write(name);
            Console.ResetColor();
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
