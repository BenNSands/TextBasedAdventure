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






        public string rat2Name { get; set; }
        public int rat2HP { get; set; }
        public int rat2Dmg { get; set; }
        public int rat2Acc { get; set; }


        public string rat3Name { get; set; }
        public int rat3HP { get; set; }
        public int rat3Dmg { get; set; }
        public int rat3Acc { get; set; }


        public string rat4Name { get; set; }
        public int rat4HP { get; set; }
        public int rat4Dmg { get; set; }
        public int rat4Acc { get; set; }


        public string theTrader { get; set; }


        public string dragonName { get; set; }
        public int dragonHP { get; set; }
        public int dragonDmg { get; set; }
        public int dragonAcc { get; set; }


        public Combat(){
            rat1Name = "Rat";
            rat1HP = 10;
            rat1Dmg = 4;
            rat1Acc = 70;

            rat2Name = "Burly Rat";
            rat2HP = 18;
            rat2Dmg = 7;
            rat2Acc = 60;

            rat3Name = "Bigass Rat With a Knife";
            rat3HP = 28;
            rat3Dmg = 11;
            rat3Acc = 69; //nice

            rat4Name = "Splinter";
            rat4HP = 30;
            rat4Dmg = 14;
            rat4Acc = 95;

            theTrader = "The Trader";

            dragonName = "The Almighty Srakoan";
            dragonHP = 999999999;
            dragonDmg = 999;
            dragonAcc = 100;
        }
        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }

        public static void ye()
        {
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Stage 4");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("O-----O-----O-----X-----O");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }


            Console.SetCursorPosition(48, 12);
            Console.WriteLine($"You've Encountered a {combat.rat4Name}!");
            Thread.Sleep(800);
            Console.SetCursorPosition(51, 15);
            Console.WriteLine("Combat Has Initiated!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 12);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }


            do
            {
                while (combat.rat4HP > 0)
                {
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine("1 - Sword");
                    Console.SetCursorPosition(50, 22);
                    Console.WriteLine("2 - Punch");
                    Console.SetCursorPosition(50, 24);
                    var atkChoice = Console.ReadLine();
                    Console.SetCursorPosition(48, 20);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }

                    switch (atkChoice.ToLower())
                    {
                        case "1":
                            if (Combat.HitRoll(0, 100) < allStats.swordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat4HP = combat.rat4HP - allStats.swordDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.swordDmg} DMG!!");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(48, 20);
                                for (int i = 0; i < 200; i++)
                                {
                                    Console.Write("   ");
                                }
                            }
                            else
                            {
                                Thread.Sleep(800);
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine("You Missed!!");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(48, 20);
                                for (int i = 0; i < 200; i++)
                                {
                                    Console.Write("   ");
                                }
                            }
                            break;

                        case "2":
                            if (Combat.HitRoll(0, 100) < allStats.punchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat4HP = combat.rat4HP - allStats.punchDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.punchDmg} DMG!!");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(48, 20);
                                for (int i = 0; i < 200; i++)
                                {
                                    Console.Write("   ");
                                }
                            }
                            else
                            {
                                Thread.Sleep(800);
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine("You Missed!!");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(48, 20);
                                for (int i = 0; i < 200; i++)
                                {
                                    Console.Write("   ");
                                }
                            }
                            break;

                        case "kill the rat":
                            Thread.Sleep(800);
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(48, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            combat.rat4HP -= combat.rat4HP;
                            break;
                        default:
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine("You wait a turn");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(50, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            break;
                    }


                    if (combat.rat4HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.rat4Acc)
                        {
                            Thread.Sleep(800);
                            allStats.charHPCurrent -= combat.rat4Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.rat4Name} punches you!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.rat4Dmg} DMG!");
                            allStats.StatDisplay();
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(48, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }


                        }
                        else
                        {
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine($"The {combat.rat4Name} Missed");
                            allStats.StatDisplay();
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(48, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                        }
                    }

                }


                if (combat.rat4HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.rat4Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 2);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }
                    allStats.StatDisplay();
                    fightStatus = 4;
                }

            } while (fightStatus != 4);
            //exp gain
            var expGain3 = Combat.HitRoll(175, 250);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine($"you gained {expGain3}EXP");
            allStats.charEXP += expGain3;
            allStats.StatDisplay();
            Thread.Sleep(1000);
            Console.SetCursorPosition(50, 20);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }

            //lvl up check
            allStats.LvlUp(allStats.charEXP, allStats.charLVL, allStats.swordDmg, allStats.swordAcc);
            allStats.StatDisplay();
        }
    }
}
