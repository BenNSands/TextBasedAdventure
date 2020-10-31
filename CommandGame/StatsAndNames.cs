using System;
using System.Collections.Generic;
using System.Text;

namespace CommandGame
{
    class StatsAndNames
    {

        public string playerName { get; set; }
        //playerStats
        int charHPCurrent = 100;

        int charHPFull = 100;
        int charMPCurrent = 50;
        int charMPFull = 50;
        int charEXP = 0;
        int charLVL = 1;
        int swordDmg = 5;
        int swordAcc = 85;
        int punchDmg = 1;
        int punchAcc = 100;
        string status = "Healthy";



        //NPC Names
        string ratName = "Rat";
        string dragonName = "The Almighty Srakoan";
        string lichName = "The All-Knowing Thalmuut";
        string theTrader = "The Trader";

        public void StatDisplay()
        {
            Console.WriteLine();
            Console.SetCursorPosition(1, 2);
            Console.Write($"Name: {playerName}");
            Console.SetCursorPosition(15, 2);
            Console.Write($"LVL: {charLVL}");
            Console.SetCursorPosition(30, 2);
            Console.Write($"EXP: {charEXP}");
            Console.SetCursorPosition(45, 2);
            Console.Write($"HP: {charHPCurrent}/{charHPFull}");
            Console.SetCursorPosition(60, 2);
            Console.Write($"MP: {charMPCurrent}/{charMPFull}");
            Console.SetCursorPosition(75, 2);
            Console.Write($"Status: {status}");
        }
    }
}
