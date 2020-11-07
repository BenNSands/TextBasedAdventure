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


    }
}
