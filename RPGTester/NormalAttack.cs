using Muller.RoleplayingGameInterfaces;

namespace Muller.RPGCore
{
    public class NormalAttack : IAttack
    {
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage = GameConstants.Instance.DamageBonus + GameRandom.Instance.Rand.Next(GameConstants.Instance.DamageRange);
            target.ReceiveAttack(damage);
        }
    }
}
