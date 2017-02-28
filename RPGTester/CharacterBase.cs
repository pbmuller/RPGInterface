using Muller.RoleplayingGameInterfaces;
using System;

namespace Muller.RPGCore
{
    public class CharacterBase : ICharacter
    {

        protected const string AnonymousName = "Anonymous";
        protected static int anonymousCounter = 0;

        protected IAttack attackBehavior;

        public string CharacterClass
        {
            get;
            protected set;
        }

        public int Health
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }

        public void ReceiveAttack(int damage)
        {
            if (GameRandom.Instance.Rand.Next(GameConstants.Instance.DodgeDifficulty) != 0)
            {
                Console.WriteLine(this.Name + " takes " + damage + " damage.");
                Health -= damage;
                if (Health < 0) Health = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " dodges the attack!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} the {1} has {2} health.", Name, CharacterClass, Health);
        }
    }
}
