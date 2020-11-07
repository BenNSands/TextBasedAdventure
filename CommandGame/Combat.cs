using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CommandGame
{
    class Combat
    {


        public string rat1Name { get; set; }
        public int rat1HP { get; set; }
        public int rat1Dmg { get; set; }
        public int rat1Acc { get; set; }

        public string theTrader { get; set; }
        public string rat2Name { get; set; }
        public int rat2HP { get; set; }
        public int rat2Dmg { get; set; }
        public int rat2Acc { get; set; }
        public string dragonName { get; set; }

        public Combat(){
            rat1Name = "Rat";
            rat1HP = 10;
            rat1Dmg = 4;
            rat1Acc = 70;

            theTrader = "The Trader";

            rat2Name = "Burly Rat";
            rat2HP = 18;
            rat2Dmg = 7;
            rat2Acc = 60;

            dragonName = "The Almighty Srakoan";
        }
        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }

        public static void FightStages(string ratName, int ratHP, int ratDmg, int ratAcc)
        {
            //Console.SetCursorPosition(48, 12);
            //Console.WriteLine($"You've Encountered a {ratName}!");
            //Thread.Sleep(800);
            //Console.SetCursorPosition(51, 15);
            //Console.WriteLine("Combat Has Initiated!");
            //Thread.Sleep(1000);
            //Console.SetCursorPosition(48, 12);
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.Write("   ");
            //}


            //do
            //{
            //    while (ratHP > 0)
            //    {
            //        Console.SetCursorPosition(50, 20);
            //        Console.WriteLine("1 - Sword");
            //        Console.SetCursorPosition(50, 22);
            //        Console.WriteLine("2 - Punch");
            //        Console.SetCursorPosition(50, 24);
            //        var atkChoice = int.Parse(Console.ReadLine());
            //        Console.SetCursorPosition(48, 20);
            //        for (int i = 0; i < 200; i++)
            //        {
            //            Console.Write("   ");
            //        }

            //        switch (atkChoice)
            //        {
            //            case 1:
            //                if (Combat.HitRoll(0, 100) < allStats.swordAcc)
            //                {
            //                    Thread.Sleep(800);
            //                    ratHP = ratHP - allStats.swordDmg;
            //                    Console.SetCursorPosition(50, 20);
            //                    Console.WriteLine($"You Hit!!");
            //                    Console.SetCursorPosition(50, 21);
            //                    Console.WriteLine($"You dealt {allStats.swordDmg} DMG!!");
            //                    Thread.Sleep(1000);
            //                    Console.SetCursorPosition(48, 20);
            //                    for (int i = 0; i < 200; i++)
            //                    {
            //                        Console.Write("   ");
            //                    }
            //                }
            //                else
            //                {
            //                    Thread.Sleep(800);
            //                    Console.SetCursorPosition(50, 20);
            //                    Console.WriteLine("You Missed!!");
            //                    Thread.Sleep(1000);
            //                    Console.SetCursorPosition(48, 20);
            //                    for (int i = 0; i < 200; i++)
            //                    {
            //                        Console.Write("   ");
            //                    }
            //                }
            //                break;

            //            case 2:
            //                if (Combat.HitRoll(0, 100) < allStats.punchAcc)
            //                {
            //                    Thread.Sleep(800);
            //                    ratHP = ratHP - allStats.punchDmg;
            //                    Console.SetCursorPosition(50, 20);
            //                    Console.WriteLine($"You Hit!!");
            //                    Console.SetCursorPosition(50, 21);
            //                    Console.WriteLine($"You dealt {allStats.punchDmg} DMG!!");
            //                    Thread.Sleep(1000);
            //                    Console.SetCursorPosition(48, 20);
            //                    for (int i = 0; i < 200; i++)
            //                    {
            //                        Console.Write("   ");
            //                    }
            //                }
            //                else
            //                {
            //                    Thread.Sleep(800);
            //                    Console.SetCursorPosition(50, 20);
            //                    Console.WriteLine("You Missed!!");
            //                    Thread.Sleep(1000);
            //                    Console.SetCursorPosition(48, 20);
            //                    for (int i = 0; i < 200; i++)
            //                    {
            //                        Console.Write("   ");
            //                    }
            //                }
            //                break;

            //            default:
            //                Thread.Sleep(800);
            //                Console.SetCursorPosition(50, 20);
            //                Console.WriteLine("you looked funny at the rat and it just fuckin' died");
            //                Thread.Sleep(1000);
            //                Console.SetCursorPosition(48, 20);
            //                for (int i = 0; i < 200; i++)
            //                {
            //                    Console.Write("   ");
            //                }
            //                ratHP -= ratHP;
            //                break;
            //        }


            //        if (ratHP > 0)
            //        {
            //            if (Combat.HitRoll(0, 100) < ratAcc)
            //            {
            //                Thread.Sleep(800);
            //                allStats.charHPCurrent -= ratDmg;
            //                Console.SetCursorPosition(50, 20);
            //                Console.Write($"The {ratName} punches you!");
            //                Console.SetCursorPosition(50, 21);
            //                Console.WriteLine($"You took {ratDmg} DMG!");
            //                allStats.StatDisplay();
            //                Thread.Sleep(1000);
            //                Console.SetCursorPosition(48, 20);
            //                for (int i = 0; i < 200; i++)
            //                {
            //                    Console.Write("   ");
            //                }


            //            }
            //            else
            //            {
            //                Console.SetCursorPosition(50, 20);
            //                Console.WriteLine($"The {ratName} Missed");
            //                allStats.StatDisplay();
            //                Thread.Sleep(1000);
            //                Console.SetCursorPosition(48, 20);
            //                for (int i = 0; i < 200; i++)
            //                {
            //                    Console.Write("   ");
            //                }
            //            }
            //        }

            //    }


            //    if (ratHP <= 0)
            //    {
            //        Thread.Sleep(1000);
            //        Console.SetCursorPosition(50, 20);
            //        Console.WriteLine($"The {ratName} has died!");
            //        Thread.Sleep(1000);
            //        Console.SetCursorPosition(48, 2);
            //        for (int i = 0; i < 200; i++)
            //        {
            //            Console.Write("   ");
            //        }
            //        allStats.StatDisplay();
            //        fightStatus = 2;
            //    }

            //} while (fightStatus != 2);

            //var expGain2 = Combat.HitRoll(120, 235);
            //Console.SetCursorPosition(50, 20);
            //Console.WriteLine($"you gained {expGain2}EXP");
            //allStats.charEXP += expGain2;
            //allStats.StatDisplay();
            //Thread.Sleep(1000);
            //Console.SetCursorPosition(48, 20);
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.Write("   ");
            //}
            ////check if still lvl 1
            //if (allStats.charEXP >= 100 || allStats.charLVL == 1)
            //{
            //    Thread.Sleep(800);
            //    Console.SetCursorPosition(50, 20);
            //    Console.WriteLine("You Leveled up!!!");
            //    allStats.charLVL += 1;
            //    allStats.StatDisplay();
            //    Thread.Sleep(800);
            //    Console.SetCursorPosition(50, 21);
            //    Console.WriteLine($"You feel like you got stronger!");
            //    allStats.swordDmg += 3;
            //    allStats.swordAcc += 5;
            //    Thread.Sleep(1000);
            //    Console.SetCursorPosition(48, 20);
            //    for (int i = 0; i < 200; i++)
            //    {
            //        Console.Write("   ");
            //    }
            //}
            ////exp gain and lvl up
            //if (allStats.charEXP >= 300)
            //{
            //    Thread.Sleep(800);
            //    Console.SetCursorPosition(50, 20);
            //    Console.WriteLine("You Leveled up!!!");
            //    allStats.charLVL += 1;
            //    allStats.StatDisplay();
            //    Thread.Sleep(800);
            //    Console.SetCursorPosition(50, 21);
            //    Console.WriteLine($"You feel like you got stronger!");
            //    allStats.swordDmg += 4;
            //    allStats.swordAcc += 5;
            //    Thread.Sleep(1000);
            //    Console.SetCursorPosition(48, 20);
            //    for (int i = 0; i < 200; i++)
            //    {
            //        Console.Write("   ");
            //    }
            //}
        } //end of fight stages method



    }
}
