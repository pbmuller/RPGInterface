﻿namespace Muller.RoleplayingGameInterfaces
{
    public interface ICharacter
    {
        //Properties
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }

        //Methods
        void PerformAttack(ICharacter target);
        void ReceiveAttack(int damage);
    }
}
