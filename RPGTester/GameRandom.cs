using System;

namespace Muller.RPGCore
{
    class GameRandom
    {
        private Random rand = new Random();

        private static GameRandom instance = new GameRandom();

        private GameRandom()
        {
        }

        public Random Rand
        {
            get { return rand; }
        }

        public static GameRandom Instance
        {
            get { return instance; }
        }
    }
}
