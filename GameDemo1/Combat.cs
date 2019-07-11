using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GameDemo1
{
    class Combat
    {
        public Monster attackingMonster { get; set; }
        public Combat()
        {
            attackingMonster = GetRandomMonster();
        }

        public CombatOutcome CombatRound(TextBox textBox)
        {

            int playerDamage = Player.DoDamage();
            string attackResponse = attackingMonster.TakeDamage(playerDamage);

            textBox.Text += "\n" + attackResponse;

            if (attackResponse == "BOOM!! Du SMÄÄÄÄCKAAA monster!")
                return CombatOutcome.PlayerWon;

            int monsterDamage = attackingMonster.DoDamage();
            string defenceResponse = Player.TakeDamage(monsterDamage);

            textBox.Text += "\n" + defenceResponse;

            if (defenceResponse == "Du är FAN SMÄÄÄÄCKAAAD!")
                return CombatOutcome.PlayerLost;

            //Implicit else
            return CombatOutcome.NewRound;


        }

        private Monster GetRandomMonster()
        {
            //List<Monster> encounterTable = new List<Monster>();

            return new Mygga();


        }
    }
}
