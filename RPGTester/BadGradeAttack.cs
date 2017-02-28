using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muller.RoleplayingGameInterfaces;

namespace Muller.RPGCore
{
    class BadGradeAttack : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " hacks Carmen and gives " + target.Name + " a bad grade!");
            base.Attack(attacker, target);
        }
    }
}
