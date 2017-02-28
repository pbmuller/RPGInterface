namespace Muller.RPGCore
{
    public class Archer : CharacterBase
    {
        public Archer(string name, int health)
        {
            this.CharacterClass = "Archer";
            this.attackBehavior = new SwordAttack();
            this.Name = name;
            this.Health = health;
        }

        public Archer(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public Archer()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHitpoints)
        {

        }
    }
}
