using Muller.RoleplayingGameInterfaces;
using System;

namespace Muller.RPGCore
{
    public class FireballAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " launches a fireball at " + target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
