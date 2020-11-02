using System;
using System.Collections.Generic;
using System.Text;

namespace CommandGame
{
    class Combat
    {

        public string rat1Name { get; set; }
        public int rat1HP { get; set; }
        public int rat1Dmg { get; set; }
        public int rat1Acc { get; set; }
        public string dragonName { get; set; }
        public string theTrader { get; set; }

        public Combat(){
            rat1Name = "Rat";
            rat1HP = 10;
            rat1Dmg = 4;
            rat1Acc = 70;
            dragonName = "The Almighty Srakoan";
            theTrader = "The Trader";
        }
        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }

        //begin combat
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
    }
}
