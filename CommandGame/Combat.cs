using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CommandGame
{
    class Combat
    {


        public string Rat1Name { get; set; }
        public int Rat1HP { get; set; }
        public int Rat1Dmg { get; set; }
        public int Rat1Acc { get; set; }






        public string Rat2Name { get; set; }
        public int Rat2HP { get; set; }
        public int Rat2Dmg { get; set; }
        public int Rat2Acc { get; set; }


        public string Rat3Name { get; set; }
        public int Rat3HP { get; set; }
        public int Rat3Dmg { get; set; }
        public int Rat3Acc { get; set; }


        public string Rat4Name { get; set; }
        public int Rat4HP { get; set; }
        public int Rat4Dmg { get; set; }
        public int Rat4Acc { get; set; }


        public string TheTrader { get; set; }


        public string DragonName { get; set; }
        public int DragonHP { get; set; }
        public int DragonDmg { get; set; }
        public int DragonAcc { get; set; }


        public Combat(){
            Rat1Name = "Rat";
            Rat1HP = 10;
            Rat1Dmg = 4;
            Rat1Acc = 70;

            Rat2Name = "Burly Rat";
            Rat2HP = 18;
            Rat2Dmg = 7;
            Rat2Acc = 60;

            Rat3Name = "Bigass Rat With a Knife";
            Rat3HP = 28;
            Rat3Dmg = 11;
            Rat3Acc = 69; //nice

            Rat4Name = "Splinter";
            Rat4HP = 30;
            Rat4Dmg = 14;
            Rat4Acc = 95;

            TheTrader = "The Trader";

            DragonName = "The Almighty Dragon, Srakoan";
            DragonHP = 999999999;
            DragonDmg = 999;
            DragonAcc = 100;
        }
        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }




    }
}
