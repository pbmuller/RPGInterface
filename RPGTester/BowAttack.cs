using System;
using Muller.RoleplayingGameInterfaces;

namespace Muller.RPGCore
{
    class BowAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " fires an arrow at " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
