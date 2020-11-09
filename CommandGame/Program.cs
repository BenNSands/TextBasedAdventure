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
            Console.WriteLine($"You've Encountered a {combat.Rat1Name}!");
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
                while (combat.Rat1HP > 0 && allStats.CharHPCurrent > 0)
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
                                combat.Rat1HP = combat.Rat1HP - allStats.SwordDmg;
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
                                combat.Rat1HP = combat.Rat1HP - allStats.PunchDmg;
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
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(35, 10);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            combat.Rat1HP -= combat.Rat1HP;
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


                    if (combat.Rat1HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.Rat1Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.Rat1Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.Rat1Name} scratches you!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.Rat1Dmg} DMG!");
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
                            Console.WriteLine($"The {combat.Rat1Name} Missed");
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


                if (combat.Rat1HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.Rat1Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 20);
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
            Console.WriteLine($"You've Encountered a {combat.Rat2Name}!");
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
                while (combat.Rat2HP > 0 && allStats.CharHPCurrent > 0)
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
                                combat.Rat2HP = combat.Rat2HP - allStats.SwordDmg;
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
                                combat.Rat2HP = combat.Rat2HP - allStats.PunchDmg;
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
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(35, 10);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            combat.Rat2HP -= combat.Rat2HP;
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


                    if (combat.Rat2HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.Rat2Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.Rat2Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"The {combat.Rat2Name} punches you!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.Rat2Dmg} DMG!");
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
                            Console.WriteLine($"The {combat.Rat2Name} Missed");
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


                if (combat.Rat2HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.Rat2Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 20);
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


            Console.SetCursorPosition(40, 12);
            Console.WriteLine($"You've Encountered a {combat.Rat3Name}!");
            Thread.Sleep(800);
            Console.SetCursorPosition(51, 15);
            Console.WriteLine("Combat Has Initiated!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(40, 12);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("   ");
            }


            do
            {
                while (combat.Rat3HP > 0 && allStats.CharHPCurrent > 0)
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
                                combat.Rat3HP = combat.Rat3HP - allStats.SwordDmg;
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
                                combat.Rat3HP = combat.Rat3HP - allStats.PunchDmg;
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
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(35, 10);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            combat.Rat3HP -= combat.Rat3HP;
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


                    if (combat.Rat3HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.Rat3Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.Rat3Dmg;
                            Console.SetCursorPosition(40, 20);
                            Console.Write($"The {combat.Rat3Name} swings with it's knife!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.Rat3Dmg} DMG!");
                            allStats.StatDisplay();
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(40, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }


                        }
                        else
                        {
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine($"The {combat.Rat3Name} Missed");
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


                if (combat.Rat3HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"The {combat.Rat3Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
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
            Console.WriteLine($"You've Encountered {combat.Rat4Name}!");
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
                while (combat.Rat4HP > 0 && allStats.CharHPCurrent > 0)
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
                                combat.Rat4HP = combat.Rat4HP - allStats.SwordDmg;
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
                                combat.Rat4HP = combat.Rat4HP - allStats.PunchDmg;
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
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("you looked funny at the rat and it just fuckin' died");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(35, 10);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            combat.Rat4HP -= combat.Rat4HP;
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


                    if (combat.Rat4HP > 0)
                    {
                        if (Combat.HitRoll(0, 100) < combat.Rat4Acc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.Rat4Dmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"{combat.Rat4Name} Hits you with his stick!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.Rat4Dmg} DMG!");
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
                            Console.WriteLine($"{combat.Rat4Name} Missed");
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


                if (combat.Rat4HP <= 0)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine($"{combat.Rat4Name} has died!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(48, 20);
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
            Console.WriteLine($"you gained {expGain4}EXP");
            allStats.CharEXP += expGain4;
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
            Console.SetCursorPosition(50, 10);
            Console.WriteLine($"Hello {allStats.PlayerName}...");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("You have done well to make it this far");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Take this and heal up");
            if (allStats.CharHPCurrent < allStats.CharHPFull)
            {
                allStats.CharHPCurrent = allStats.CharHPFull;
            }
            allStats.StatDisplay();
            
            Console.SetCursorPosition(50, 13);
            Thread.Sleep(2000);
            Console.WriteLine("and one piece of advise for you");
            Thread.Sleep(1200);
            Console.SetCursorPosition(50, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("     ");
            }
            Thread.Sleep(1000);
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DON'T FIGHT THE DRAGON");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Simply Wait");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.SetCursorPosition(50, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("    ");
            }
            //end of trader stage for now

            //start of dragon stage
            //
            //
            //
            //
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
            Thread.Sleep(1000);
            Console.SetCursorPosition(50, 10);
            Console.WriteLine($"You have encountered {combat.DragonName}!!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("Combat has Initiated!");
            Thread.Sleep(2000);
            Console.SetCursorPosition(50, 10);
            for (int i = 0; i < 200; i++)
            {
                Console.Write("  ");
            }
            var dragonRage = 10;
            do
            {
                do
                {
                    Console.SetCursorPosition(50, 18);
                    Console.WriteLine("What will you do?");
                    Console.SetCursorPosition(50, 20);
                    Console.WriteLine("1 - Sword");
                    Console.SetCursorPosition(50, 22);
                    Console.WriteLine("2 - Punch");
                    Console.SetCursorPosition(50, 24);
                    var atkChoice = Console.ReadLine();
                    Console.SetCursorPosition(50, 18);
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
                                combat.DragonHP = combat.DragonHP - allStats.SwordDmg;
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
                                combat.DragonHP = combat.DragonHP - allStats.PunchDmg;
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

                        case "wait": // Need to change dialouge and not kill dragon
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine("You wait a turn");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(50, 20);
                            dragonRage--;
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            break;
                        default:
                            Console.SetCursorPosition(50, 20);
                            Console.WriteLine("You wait a turn");
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(50, 20);
                            dragonRage--;
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                            break;
                    }


                    if (combat.DragonHP < 999999999)
                    {
                        if (Combat.HitRoll(0, 100) < combat.DragonAcc)
                        {
                            Thread.Sleep(800);
                            allStats.CharHPCurrent -= combat.DragonDmg;
                            Console.SetCursorPosition(50, 20);
                            Console.Write($"{combat.DragonName} Breathes a Scorching Flame!");
                            Console.SetCursorPosition(50, 21);
                            Console.WriteLine($"You took {combat.DragonDmg} DMG!");
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
                            Console.WriteLine($"{combat.DragonName} Missed");
                            allStats.StatDisplay();
                            Thread.Sleep(1000);
                            Console.SetCursorPosition(48, 20);
                            for (int i = 0; i < 200; i++)
                            {
                                Console.Write("   ");
                            }
                        }
                    }


                } while ((combat.DragonHP > 0 && allStats.CharHPCurrent > 0) && dragonRage == 10);
                Console.SetCursorPosition(40,15);
                Thread.Sleep(1000);
                Console.WriteLine($"So I see you are cabable of thought... so your name is {allStats.PlayerName}");
                Console.SetCursorPosition(40, 16);
                Thread.Sleep(1000);
                Console.WriteLine($"Congradulations on reaching the end of the dungeon {allStats.PlayerName}");
                Thread.Sleep(2000);
                Console.SetCursorPosition(40, 15);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("     ");
                }
                dragonRage = 0;

            } while (dragonRage != 0);


            if (allStats.CharHPCurrent > 0)
            {
                startGame.EndScreen();
            }
            if (allStats.CharHPCurrent <= 0)
            {
              
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over...");
                Console.ResetColor();
                Console.ReadLine();
            }
            







        }//end of main
    }//end of class
}//end of namespace

