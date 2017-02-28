using Muller.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;

namespace Muller.RPGCore
{
    class Program
    {
        private IList<ICharacter> playerParty = new List<ICharacter>();
        static void Main(string[] args)
        {
            IParty playerParty = new Party();
            playerParty.PopulateParty();

            IParty enemyParty = new Party();
            enemyParty.PopulateEnemyParty();

            ICharacter player1 = new Mage("Gandalf");
            ICharacter player2 = new Warrior("Boromir");

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            player1.PerformAttack(player2);

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            player2.PerformAttack(player1);

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            Console.ReadLine();
        }
    }
}
