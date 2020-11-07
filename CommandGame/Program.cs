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
            allStats.PlayerName = Console.ReadLine();
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
            Console.WriteLine($"Here, you dropped your Sword {allStats.PlayerName}! Now get out there and take care of those Rats!");// want to change the dialouge here (need more instructions)

            allStats.StatDisplay();

            Thread.Sleep(2000);
            Console.SetCursorPosition(48, 8);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("    ");
            }

            //begin stage 1
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
                    var atkChoice = Console.ReadLine();
                    Console.SetCursorPosition(48, 20);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }

                    switch (atkChoice.ToLower())
                    {
                        case "1":
                            if (Combat.HitRoll(0, 100) < allStats.SwordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat1HP = combat.rat1HP - allStats.SwordDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.SwordDmg} DMG!!");
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

                        case  "2":
                            if (Combat.HitRoll(0, 100) < allStats.PunchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat1HP = combat.rat1HP - allStats.PunchDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.PunchDmg} DMG!!");
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
                            combat.rat1HP -= combat.rat1HP;
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


                    if (combat.rat1HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.rat1Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.rat1Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.rat1Name} scratches you!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.rat1Dmg} DMG!");
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
                            Console.WriteLine($"The {combat.rat1Name} Missed");
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


                if (combat.rat1HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.rat1Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 2);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }
                    allStats.StatDisplay();
                    fightStatus = 1;
                }

            } while (fightStatus != 1);
            //exp gain
            var expGain = Combat.HitRoll(60, 145);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine($"you gained {expGain}EXP");
            allStats.CharEXP += expGain;
            allStats.StatDisplay();
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 20);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }
            // lvl up check

            allStats.LvlUp(allStats.CharEXP, allStats.CharLVL, allStats.SwordDmg, allStats.SwordAcc);
            allStats.StatDisplay();





            //start stage 2
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Stage 2");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("O-----X-----O-----O-----O");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }



            Console.SetCursorPosition(48, 12);
            Console.WriteLine($"You've Encountered a {combat.rat2Name}!");
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
                while (combat.rat2HP > 0)
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
                            if (Combat.HitRoll(0, 100) < allStats.SwordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat2HP = combat.rat2HP - allStats.SwordDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.SwordDmg} DMG!!");
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
                            if (Combat.HitRoll(0, 100) < allStats.PunchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat2HP = combat.rat2HP - allStats.PunchDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.PunchDmg} DMG!!");
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
                            combat.rat2HP -= combat.rat2HP;
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


                    if (combat.rat2HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.rat2Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.rat2Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.rat2Name} punches you!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.rat2Dmg} DMG!");
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
                            Console.WriteLine($"The {combat.rat2Name} Missed");
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


                if (combat.rat2HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.rat2Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 2);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }
                    allStats.StatDisplay();
                    fightStatus = 2;
                }

            } while (fightStatus != 2);
            //exp gain
            var expGain2 = Combat.HitRoll(130, 235);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine($"you gained {expGain2}EXP");
            allStats.CharEXP += expGain2;
            allStats.StatDisplay();
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 20);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }

            //lvl up check
            allStats.LvlUp(allStats.CharEXP, allStats.CharLVL, allStats.SwordDmg, allStats.SwordAcc);
            allStats.StatDisplay();










            //start stage 3
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Stage 3");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("O-----O-----X-----O-----O");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }


            Console.SetCursorPosition(48, 12);
            Console.WriteLine($"You've Encountered a {combat.rat3Name}!");
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
                while (combat.rat3HP > 0)
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
                            if (Combat.HitRoll(0, 100) < allStats.SwordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat3HP = combat.rat3HP - allStats.SwordDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.SwordDmg} DMG!!");
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
                            if (Combat.HitRoll(0, 100) < allStats.PunchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat3HP = combat.rat3HP - allStats.PunchDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.PunchDmg} DMG!!");
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
                            combat.rat3HP -= combat.rat3HP;
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


                    if (combat.rat3HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.rat3Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.rat3Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.rat3Name} swings with it's knife!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.rat3Dmg} DMG!");
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
                            Console.WriteLine($"The {combat.rat3Name} Missed");
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


                if (combat.rat3HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.rat3Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 2);
                    for (int i = 0; i < 200; i++)
                    {
                        Console.Write("   ");
                    }
                    allStats.StatDisplay();
                    fightStatus = 3;
                }

            } while (fightStatus != 3);
            //exp gain
            var expGain3 = Combat.HitRoll(175, 250);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine($"you gained {expGain3}EXP");
            allStats.CharEXP += expGain3;
            allStats.StatDisplay();
            Thread.Sleep(1000);
            Console.SetCursorPosition(50, 20);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }

            //lvl up check
            allStats.LvlUp(allStats.CharEXP, allStats.CharLVL, allStats.SwordDmg, allStats.SwordAcc);
            allStats.StatDisplay();

            //end of stage 3

            //start stage 4
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
            Console.WriteLine($"You've Encountered {combat.rat4Name}!");
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
                            if (Combat.HitRoll(0, 100) < allStats.SwordAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat4HP = combat.rat4HP - allStats.SwordDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.SwordDmg} DMG!!");
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
                            if (Combat.HitRoll(0, 100) < allStats.PunchAcc)
                            {
                                Thread.Sleep(800);
                                combat.rat4HP = combat.rat4HP - allStats.PunchDmg;
                                Console.SetCursorPosition(50, 20);
                                Console.WriteLine($"You Hit!!");
                                Console.SetCursorPosition(50, 21);
                                Console.WriteLine($"You dealt {allStats.PunchDmg} DMG!!");
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
                            allStats.CharHPCurrent -= combat.rat4Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"{combat.rat4Name} punches you!");
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
                            Console.WriteLine($"{combat.rat4Name} Missed");
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
                    Console.WriteLine($"{combat.rat4Name} has died!");
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
            var expGain4 = Combat.HitRoll(290, 380);
            Console.SetCursorPosition(50, 20);
            Console.WriteLine($"you gained {expGain3}EXP");
            allStats.CharEXP += expGain3;
            allStats.StatDisplay();
            Thread.Sleep(1000);
            Console.SetCursorPosition(50, 20);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }

            //lvl up check
            allStats.LvlUp(allStats.CharEXP, allStats.CharLVL, allStats.SwordDmg, allStats.SwordAcc);
            allStats.StatDisplay();

            //end stage 4

            //start trader stage
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("The Trader");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("O-----O-----O-----O--T--O");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }
            Console.SetCursorPosition(54, 10);
            Console.WriteLine($"Hello {allStats.PlayerName}...");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("You have done well to make it this far");
            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Take this and heal up");
            if (allStats.CharHPCurrent < allStats.CharHPFull)
            {
                allStats.CharHPCurrent = allStats.CharHPFull;
            }
            //end of trader stage for now

            //start of dragon stage

            Console.SetCursorPosition(54, 10);
            Console.WriteLine("Final Stage");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("O-----O-----O-----O-----X");
            Thread.Sleep(2000);
            Console.SetCursorPosition(54, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }

            //stop
            Console.ReadLine();














        }//end of main
    }//end of class
}//end of namespace

