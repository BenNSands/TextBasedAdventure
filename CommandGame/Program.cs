using System;
using System.Threading;
using System.Collections.Generic;

//namespace InventorySystem
//{
//    public abstract class ObtainableItem
//    {
//        public Guid ID { get; set; }
//        public string Name { get; set; }
//        public int MaximumStackableQuantity { get; set; }

//        protected ObtainableItem()
//        {
//            MaximumStackableQuantity = 1;
//        }
//    }
//}
namespace CommandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var startGame = new StartScreen();
            var allStats = new StatsAndNames();
            var combatSteps = new Combat();

            startGame.OpeningScreen();

            allStats.StatDisplay();

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Hello Slayer! What's your name?");
            Console.SetCursorPosition(7, 2);
            allStats.playerName = Console.ReadLine();
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 8);
            for (int i = 0; i < 200; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Good, you remeber.");
            Thread.Sleep(1000);
            Console.WriteLine($"Here, you dropped your Sword {allStats.playerName}! Now get out there and take care of those Rats!");// want to change the dialouge here (need more instructions)

            allStats.StatDisplay();

            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 8);
            for (int i = 0; i < 200; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(55, 10);
            Console.WriteLine("Stage 1");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("X-----O-----O-----O-----O");
            Thread.Sleep(1200);
            Console.SetCursorPosition(55, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }




            //stop
            Console.ReadLine();

            

            

            //Console.WriteLine();
       
            //var ans = 0;
            //do
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*You are faced with two doors, which do you choose?*");
            //    Console.WriteLine();

            //    // First fork in the road
            //    Console.WriteLine("1 - Enter to follow the path of the Dragon   *COMBAT*");
            //    Console.WriteLine();
            //    Console.WriteLine("2 - Enter to follow the path of the Lich Lord   *PUZZLES*");
            //    var firstChoice = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    if(firstChoice == 1 || firstChoice == 2)
            //    {
            //        ans = 1;
            //    }
            //} while (ans == 0);

            //switch(firstChoice)// First Split
            //{       //start if the combat line
            //    case 1:
            //        Console.Write($"You enter the room, and are greeted by the ");
            //        Console.WriteLine();
            //        //npcNames(ratName);
            //        Console.Write(" holding a Knife!");
            //        Thread.Sleep(800);
            //    Console.WriteLine();

            //        int ratHP = 8;// declaring rat hp and dmg
            //        int ratDMG = 4;
            //        int ratAcc = 70;

            //        Console.WriteLine("Combat has been Initiated!!!");
            //        Thread.Sleep(800);
            //            for (int i = 0; i < 15; i++) {

            //            if (ratHP > 0)
            //            {
            //                Console.WriteLine($"{15 - i} Rounds left in combat.");
            //                Console.WriteLine();
            //                Thread.Sleep(800);
            //                Console.Write("1 - Attack the ");
            //                npcNames(ratName);
            //                Console.WriteLine(" with your Sword");

            //                Console.WriteLine();

            //                Console.Write($"2 - Punch the ");
            //                npcNames(ratName);

            //                Console.WriteLine();
            //                var ratCombat = int.Parse(Console.ReadLine());
            //                switch (ratCombat)
            //                {
            //                    case 1:

            //                        if (HitRoll(0, 100) < swordAcc)
            //                        {
            //                            Thread.Sleep(800);
            //                            ratHP = ratHP - swordDmg;
            //                            Console.WriteLine($"You Hit!!");
            //                            Console.WriteLine($"You dealt {swordDmg} DMG!!");
            //                        }
            //                        else 
            //                        {
            //                            Thread.Sleep(800);
            //                            Console.WriteLine("You Missed!!");
            //                        }

            //                        break;
            //                    case 2:
            //                        if (HitRoll(0, 100) < punchAcc)
            //                        {
            //                            Thread.Sleep(800);
            //                            ratHP = ratHP - punchDmg;
            //                            Console.WriteLine($"You Hit!!");
            //                            Console.WriteLine($"You dealt {punchDmg} DMG!!");
            //                        }
            //                        break;
            //                    default:
            //                        Thread.Sleep(800);
            //                        Console.WriteLine("You passed this Turn.");
            //                        break;
            //                }
            //                if (ratHP > 0)
            //                {
            //                    if (HitRoll(0, 100) < ratAcc)
            //                    {
            //                        Thread.Sleep(800);
            //                        HP = HP - ratDMG;
            //                        Console.Write("The ");
            //                        npcNames(ratName);
            //                        Console.Write(" swings it's knife!");
            //                        Thread.Sleep(800);
            //                        Console.WriteLine($"You took {ratDMG} DMG!");

            //                        DisplayStats(HP, MP);

            //                    } 
            //                    else
            //                    {
            //                        Console.Write("The ");
            //                        npcNames(ratName);
            //                        Console.Write(" swings it's knife!");
            //                        Thread.Sleep(800);
            //                        Console.WriteLine("The Rat Missed");
            //                        DisplayStats(HP, MP);
            //                    }

            //                }

            //            }
            //            else
            //            {
            //                Thread.Sleep(1000);
            //                Console.WriteLine();
            //                Console.Write("The ");
            //                npcNames(ratName);
            //                Console.Write(" has died!");
            //                Thread.Sleep(1000);
            //                Console.WriteLine();
            //                Console.WriteLine($"{playerName} has gained 100 EXP");
            //                EXP += 100; 

            //                i = 15;
            //            }
            //        }//end of combat

            //        Thread.Sleep(1500);
            //        Console.WriteLine("");
            //        break;



            //        //start of puzzle line
            //    case 2:

            //    Console.WriteLine("You enter the room, and hear an eerie noise in the walls, there is a hole in the wall leading into a cave.");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Investigate the noise");
            //    Console.WriteLine("2 - Head straight to the exit");
            //    var spoopy = int.Parse(Console.ReadLine());
            //    switch(spoopy)
            //    {
            //        case 1:
            //            Console.WriteLine($"{playerName}...... Why have you abandoned meeeee?....");
            //            Console.WriteLine("You feel as if your soul is slowly being tugged out of you body *You lose 10 MP*");
            //            Console.WriteLine();

            //            MP = MP - 10;
            //               // DisplayStats(HP, MP);
            //                // Console.WriteLine("exit the room start next trial");
            //                break;
            //        case 2:
            //            // Console.WriteLine("exit the room start next trial");
            //            break;
            //        default:
            //            break;
            //    }
            //        break;



            //    default:
            //    Console.WriteLine("You fall into a hidden pit and take 99 DMG");
            //        Console.WriteLine();
            //    HP = HP - 99;
            //        //DisplayStats(HP, MP);
            //        // need to continue with something here
            //        break;
            //}
            //end of first challenges

        }//end of main
    }
}
