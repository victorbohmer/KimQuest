﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    static class Player
    {
        static public int Health { get; private set; } = 100;
        static public int Gold { get; private set; } = 10;
        static public int Experience { get; private set; } = 0;
        static public int Level { get; private set; } = 1;
        static public int ExperinceToLevelUp { get; } = 100;


        static private int minDamage = 10;
        static private int maxDamage = 25;
       
        static public int DoDamage()
        {
            Random random = new Random();
            return random.Next(minDamage, maxDamage);
        }
        static public CombatOutcome TakeDamage(int damageTaken, string monsterName)
        {
            Health -= damageTaken;
            if (Health > 0)
            {
                return CombatOutcome.NewRound;
                //return $"{monsterName} smäll tillbax för {damageTaken} skada!";
            }
            else
            {
                return CombatOutcome.PlayerLost;
                //return $"{monsterName} smäll tillbax för {damageTaken} skada! \nDu är FAN SMÄÄÄÄCKAAAD!";
            }

        }
        static public string AddExperience(int experienceGained)
        {
            

            Experience += experienceGained;

            int resultOfAddedExperience = ExperinceToLevelUp - Experience;

            if (Experience >= ExperinceToLevelUp)
            {
                LevelUp();
                Experience -= ExperinceToLevelUp;
                return "Grattis du har gått upp en level!";
            }
            else
            {
               return $"Du fick {experienceGained} xp och har kvar {resultOfAddedExperience} xp till nästa level!";
            }
        }
        static void LevelUp()
        {
            Level++;
            Health += 20;
            minDamage += 5;
            maxDamage += 5;
        }


    }
}
