using Muller.RoleplayingGameInterfaces;
using System;

namespace Muller.RPGCore
{
    public class SwordAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " swings a sword at " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
