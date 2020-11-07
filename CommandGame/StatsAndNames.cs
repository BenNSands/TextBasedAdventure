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

        public string playerName { get; set; }
        //playerStats
        public int charHPCurrent { get; set; }
        public int charHPFull { get; }
        public int charMPCurrent { get; set; }
        public int charMPFull { get; }
        public int charEXP { get; set; }
        public int charLVL { get; set; }
        public string status { get; set; }
        public int swordDmg { get; set; }
        public int swordAcc { get; set; }
        public int punchDmg { get; set; }
        public int punchAcc { get; set; }
       
        public StatsAndNames()
        {
            charHPCurrent = 100;
            charHPFull = 100;
            charMPCurrent = 50;
            charMPFull = 50;
            charEXP = 0;
            charLVL = 1;
            swordDmg = 5;
            swordAcc = 85;
            punchDmg = 1;
            punchAcc = 100;
            status = "Healthy";
           
           
            

        }



        

        public void StatDisplay()
        {
            Console.WriteLine();
            Console.SetCursorPosition(1, 2);
            Console.Write($"Name: {playerName}");
            Console.SetCursorPosition(20, 2);
            Console.Write($"LVL: {charLVL}");
            Console.SetCursorPosition(40, 2);
            Console.Write($"EXP: {charEXP}");
            Console.SetCursorPosition(60, 2);
            Console.Write($"HP: {charHPCurrent}/{charHPFull}");
            Console.SetCursorPosition(80, 2);
            Console.Write($"MP: {charMPCurrent}/{charMPFull}");
            Console.SetCursorPosition(100, 2);
            Console.Write($"Status: {status}");
        }

        public static void npcNames(string name)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name);
            Console.ResetColor();
        }


        public void LvlUp(int exp, int lvl)
        {
            if (exp >= 100 && lvl == 1)
            {
                Thread.Sleep(800);
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("You Leveled up!!!");

                lvl += 1;

                Thread.Sleep(800);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 100;
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

                lvl += 1;

                Thread.Sleep(800);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 150;
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

                lvl += 1;

                Thread.Sleep(800);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 200;
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

                lvl += 1;

                Thread.Sleep(800);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 300;
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

                lvl += 1;

                Thread.Sleep(800);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine($"You feel like you got stronger!");
                exp -= 500;
                Thread.Sleep(1000);
                Console.SetCursorPosition(50, 20);
                for (int i = 0; i < 200; i++)
                {
                    Console.Write("   ");
                }
            }
        }
    }
}
