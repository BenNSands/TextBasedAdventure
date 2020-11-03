using System;
using System.Threading;
using System.Collections.Generic;


namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var startGame = new StartScreen();
            var allStats = new StatsAndNames();
            var combat = new Combat();

            startGame.OpeningScreen();

            allStats.StatDisplay();

            Console.SetCursorPosition(45, 8);
            Console.WriteLine("Hello Slayer! What's your name?");
            Console.SetCursorPosition(7, 2);
            allStats.playerName = Console.ReadLine();
            Thread.Sleep(1000);
            Console.SetCursorPosition(45, 8);
            for (int i = 0; i < 200; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(48, 8);
            Console.WriteLine("Good, you remeber.");
            Thread.Sleep(1000);
            Console.SetCursorPosition(25, 10);
            Console.WriteLine($"Here, you dropped your Sword {allStats.playerName}! Now get out there and take care of those Rats!");// want to change the dialouge here (need more instructions)

            allStats.StatDisplay();

            Thread.Sleep(2000);
            Console.SetCursorPosition(48, 8);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("    ");
            }

            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Stage 1");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("X-----O-----O-----O-----O");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }


            Console.SetCursorPosition(48, 12);
            Console.WriteLine($"You've Encountered a {combat.rat1Name}!");
            Thread.Sleep(800);
            Console.SetCursorPosition(51, 15);
            Console.WriteLine("Combat Has Initiated!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 12);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }

            //need to change cursor position below here and line erasure
            var fightStatus = 0;
            do
            {
                while (combat.rat1HP > 0)
                {
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine("1 - Sword");
                    Console.SetCursorPosition(50, 22);
                    Console.WriteLine("2 - Punch");
                    Console.SetCursorPosition(50, 24);
                    var atkChoice = int.Parse(Console.ReadLine());

                    switch (atkChoice)
                    {
                        case 1:
                            if (combat.HitRoll(0, 100) < allStats.swordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat1HP = combat.rat1HP - allStats.swordDmg;
                                Console.WriteLine($"You Hit!!");
                                Console.WriteLine($"You dealt {allStats.swordDmg} DMG!!");
                            }
                            else
                            {
                                Thread.Sleep(800);
                                Console.WriteLine("You Missed!!");
                            }
                            break;

                        case 2:
                            if (combat.HitRoll(0, 100) < allStats.punchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat1HP = combat.rat1HP - allStats.punchDmg;
                                Console.WriteLine($"You Hit!!");
                                Console.WriteLine($"You dealt {allStats.punchDmg} DMG!!");
                            }
                            else
                            {
                                Thread.Sleep(800);
                                Console.WriteLine("You Missed!!");
                            }
                            break;

                        default:
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            combat.rat1HP -= combat.rat1HP;
                            break;
                    }


                    if (combat.rat1HP > 0)
                    {
                        if (combat.HitRoll(0, 100) < combat.rat1Acc)
                        {
                            Thread.Sleep(800);
                            allStats.charHPCurrent -= combat.rat1Dmg;
                            Console.Write($"The {combat.rat1Name}swings it's knife!");
                            Console.WriteLine($"You took {combat.rat1Dmg} DMG!");
                            allStats.StatDisplay();

                        }
                        else
                        {

                            Console.WriteLine($"The {combat.rat1Name} Missed");
                            allStats.StatDisplay();
                        }
                    }
                    Console.WriteLine($"The {combat.rat1Name} has died!");
                }

                var expGain = combat.HitRoll(40, 120);
                Console.WriteLine($"you gained {expGain}EXP");
                allStats.charEXP += expGain;

                allStats.StatDisplay();
                fightStatus = 1;
            } while (fightStatus != 1) ;
            if (allStats.charEXP >= 100)
            {
                Console.WriteLine("You Leveled up!!!");
                allStats.charLVL += 1;
            }



                //stop
                Console.ReadLine();














        }//end of main
    }//end of class
}//end of namespace

