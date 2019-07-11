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
        public string TakeDamage(int damageTaken)
        {
            if (damageTaken < Health)
            {
                Health -= damageTaken;
                return $"Du tog {damageTaken} i skada! från monster 'vadnumonsternamnär' Du har kvar {Health} i liv";
            }
            else
            {
                return "Du är FAN SMÄÄÄÄCKAAAD!";
            }

        }

    }
}
