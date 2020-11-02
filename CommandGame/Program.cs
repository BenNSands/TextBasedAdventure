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
            Console.Write("You've Encountered a ");
            Console.Write(combat.rat1Name);
            Thread.Sleep(500);
            Console.SetCursorPosition(51, 15);
            Console.WriteLine("Combat Has Initiated!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 12);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }


            var fightStatus = 0;
            do
            {
                if (combat.rat1HP > 0)
                {

                }
            } while (fightStatus != 1);

            //            for (int i = 0; i < 15; i++)
            //{

            //    if (combat.rat1HP > 0)
            //    {
            //        Console.WriteLine($"{15 - i} Rounds left in combat.");
            //        Console.WriteLine();
            //        Thread.Sleep(800);
            //        Console.Write("1 - Attack the ");
            //        npcNames(ratName);
            //        Console.WriteLine(" with your Sword");

            //        Console.WriteLine();

            //        Console.Write($"2 - Punch the ");
            //        npcNames(ratName);

            //        Console.WriteLine();
            //        var ratCombat = int.Parse(Console.ReadLine());
            //        switch (ratCombat)
            //        {
            //            case 1:

            //                if (HitRoll(0, 100) < swordAcc)
            //                {
            //                    Thread.Sleep(800);
            //                    ratHP = ratHP - swordDmg;
            //                    Console.WriteLine($"You Hit!!");
            //                    Console.WriteLine($"You dealt {swordDmg} DMG!!");
            //                }
            //                else
            //                {
            //                    Thread.Sleep(800);
            //                    Console.WriteLine("You Missed!!");
            //                }

            //                break;
            //            case 2:
            //                if (HitRoll(0, 100) < punchAcc)
            //                {
            //                    Thread.Sleep(800);
            //                    ratHP = ratHP - punchDmg;
            //                    Console.WriteLine($"You Hit!!");
            //                    Console.WriteLine($"You dealt {punchDmg} DMG!!");
            //                }
            //                break;
            //            default:
            //                Thread.Sleep(800);
            //                Console.WriteLine("You passed this Turn.");
            //                break;
            //        }
            //        if (ratHP > 0)
            //        {
            //            if (HitRoll(0, 100) < ratAcc)
            //            {
            //                Thread.Sleep(800);
            //                HP = HP - ratDMG;
            //                Console.Write("The ");
            //                npcNames(ratName);
            //                Console.Write(" swings it's knife!");
            //                Thread.Sleep(800);
            //                Console.WriteLine($"You took {ratDMG} DMG!");

            //                DisplayStats(HP, MP);

            //            }
            //            else
            //            {
            //                Console.Write("The ");
            //                npcNames(ratName);
            //                Console.Write(" swings it's knife!");
            //                Thread.Sleep(800);
            //                Console.WriteLine("The Rat Missed");
            //                DisplayStats(HP, MP);
            //            }

            //        }

            //    }
            //    else
            //    {
            //        Thread.Sleep(1000);
            //        Console.WriteLine();
            //        Console.Write("The ");
            //        npcNames(ratName);
            //        Console.Write(" has died!");
            //        Thread.Sleep(1000);
            //        Console.WriteLine();
            //        Console.WriteLine($"{playerName} has gained 100 EXP");
            //        EXP += 100;

            //        i = 15;
            //    }
            //}//end of combat

            //stop
            Console.ReadLine();

            

            

       

            




  

        }//end of main
    }
}
