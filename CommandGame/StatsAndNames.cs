using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace CommandGame
{
    class StatsAndNames
    {

        public string PlayerName { get; set; }
        //playerStats
        public int CharHPCurrent { get; set; }
        public int CharHPFull { get; }
        public int CharMPCurrent { get; set; }
        public int CharMPFull { get; }
        public int CharEXP { get; set; }
        public int CharLVL { get; set; }
        public string Status { get; set; }
        public int SwordDmg { get; set; }
        public int SwordAcc { get; set; }
        public int PunchDmg { get; set; }
        public int PunchAcc { get; set; }
       
        public StatsAndNames()
        {
            CharHPCurrent = 100;
            CharHPFull = 100;
            CharMPCurrent = 50;
            CharMPFull = 50;
            CharEXP = 0;
            CharLVL = 1;
            SwordDmg = 5;
            SwordAcc = 85;
            PunchDmg = 1;
            PunchAcc = 100;
            Status = "Healthy";
           
           
            

        }



        

        public void StatDisplay()
        {
            Console.WriteLine();
            Console.SetCursorPosition(1, 2);
            Console.Write($"Name: {PlayerName}");
            Console.SetCursorPosition(20, 2);
            Console.Write($"LVL: {CharLVL}");
            Console.SetCursorPosition(40, 2);
            Console.Write($"EXP: {CharEXP}");
            Console.SetCursorPosition(60, 2);
            Console.Write($"HP: {CharHPCurrent}/{CharHPFull}");
            Console.SetCursorPosition(80, 2);
            Console.Write($"MP: {CharMPCurrent}/{CharMPFull}");
            Console.SetCursorPosition(100, 2);
            Console.Write($"Status: {Status}");
        }

        public void npcNames(string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name);
            Console.ResetColor();
        }


        public void LvlUp(int exp, int lvl, int dmg, int acc)
        {
            if (exp >= 100 && lvl == 1)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl ++;

                Thread.Sleep(800);
                Console.SetCursorPosition(45, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 100;
                dmg += 3;
                acc += 5;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }

            if (exp >= 150 && lvl == 2)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl ++;

                Thread.Sleep(800);
                Console.SetCursorPosition(45, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 150;
                dmg += 6;
                acc += 5;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }

            if (exp >= 200 && lvl == 3)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl ++;

                Thread.Sleep(800);
                Console.SetCursorPosition(45, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 200;
                dmg += 7;
                acc += 5;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }

            if (exp >= 300 && lvl == 4)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl ++;

                Thread.Sleep(800);
                Console.SetCursorPosition(45, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 300;
                dmg += 10;
                acc += 5;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }

            if (exp>= 500 && lvl == 5)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl ++;

                Thread.Sleep(800);
                Console.SetCursorPosition(45, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 500;
                dmg += 20;
                acc += 5;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }
        }//end of lvl up
    }
}
