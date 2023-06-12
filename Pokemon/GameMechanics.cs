using System;

namespace Pokemon
{
    public static class GameMechanics
    {
        private static Random random = new Random();

        public static int CalculateDamage(int minDamage, int maxDamage)
        {
            return random.Next(minDamage, maxDamage + 1);
        }

        public static bool IsCriticalHit()
        {
            return random.Next(0, 100) < 10; // 10% chance of critical hit
        }
    }
}
