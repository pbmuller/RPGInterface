using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muller.RoleplayingGameInterfaces
{
    public interface IParty
    {
        IList<ICharacter> partyList { get; }

        void PopulateParty();

        void PopulateEnemyParty();
    }
}
