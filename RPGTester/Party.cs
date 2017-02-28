using Muller.RoleplayingGameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muller.RPGCore
{
    class Party : IParty
    {
        public IList<ICharacter> partyList
        {
            get
            {
                return new List<ICharacter>();
            }
        }

        public void PopulateParty()
        {
            string size;
            int partySize;

            bool partyPopulated = false;

            Console.WriteLine("Your party may consist of a lone wanderer or a  group of adventures out seeking their fortune.");
            Console.WriteLine("Your party size can range from 1 to 4.");
            Console.WriteLine("What size will your party be?");
            size = Console.ReadLine();

            while (!partyPopulated)
            {
                if (Int32.TryParse(size, out partySize) && (partySize.Equals(1) || partySize.Equals(2) || partySize.Equals(3) || partySize.Equals(4)))
                {
                    for (int i = 0; i < partySize; i++)
                    {
                        partyList.Add(Helper.MakeCharacter());
                    }
                    partyPopulated = true;
                }
            }
        }

        public void PopulateEnemyParty()
        {
            partyList.Add(new Warrior("Garen"));
            partyList.Add(new Mage("Syndra"));
            partyList.Add(new ComputerWizard("HeimerDinger"));
            partyList.Add(new Archer("Ashe"));
        }
    }
}
