using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    class Player
    {
        public int Health { get; private set; }
        public int Gold { get; private set; }


        private int minDamage;
        private int maxDamage;
        public Player()
        {
            minDamage = 10;
            maxDamage = 25;
            Health = 100;
            Gold = 10;
        }
        public int DoDamage()
        {
            Random random = new Random();
            return random.Next(minDamage, maxDamage);
        }



    }
}
