namespace Muller.RPGCore
{
    class GameConstants
    {
        private const int damageBonus = 5;
        private const int damageRange = 10;
        private const int dodgeDifficulty = 5;
        private const int playerHitpoints = 50;

        private static GameConstants instance = new GameConstants();

        private GameConstants()
        {
        }

        public int DamageBonus
        {
            get { return damageBonus; }
        }

        public int DamageRange
        {
            get { return damageRange; }
        }

        public int DodgeDifficulty
        {
            get { return dodgeDifficulty; }
        }

        public static GameConstants Instance
        {
            get { return instance; }
        }

        public int PlayerHitpoints
        {
            get { return playerHitpoints; }
        }
    }
}
