using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muller.RoleplayingGameInterfaces;

namespace Muller.RPGCore
{
    class Helper
    {
        //General class with some methods that should make everything look cleaner in the end
        public static ICharacter MakeCharacter()
        {
            Console.WriteLine("What will the name of this Character be?");
            string name = Console.ReadLine();

            Console.WriteLine("What class will " + name + " be?");
            
            while (true)
            {
                string charClass = Console.ReadLine().ToLower();
                switch (charClass)
                {
                    case "archer":
                        return new Archer(name);
                    case "computer wizard":
                        return new ComputerWizard(name);
                    case "mage":
                        return new Mage(name);
                    case "warrior":
                        return new Warrior(name);
                    default:
                        Console.WriteLine("Sorry, that is not a valid Class. The Character can be an Archer, Computer Wizard, mage, or Warrior");
                        break;
                }
            }
        }
    }
}
