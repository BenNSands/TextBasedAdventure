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



       
    }
}
