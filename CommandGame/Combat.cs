using System;
using System.Collections.Generic;
using System.Text;

namespace CommandGame
{
    class Combat
    {
        public static int HitRoll(int min, int max)
        {
            var rand = new Random();
            return rand.Next(min, max);

        }
    }
}
