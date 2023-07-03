using System;

namespace Pokemon
{
    // Strategy Pattern: Attack class encapsulates attack behavior
    // The IAttackStrategy interface and the Attack class represent the Strategy pattern.
    // The Pokemon class uses different attack strategies by holding a list of IAttackStrategy objects and selecting a random attack from the list during the PerformAttack method.
    public interface IAttackStrategy
    {
        int CalculateDamage();
        bool IsCriticalHit();
    }

    public class Attack : IAttackStrategy
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int CalculateDamage()
        {
            Random random = new Random();
            return random.Next(MinDamage, MaxDamage + 1);
        }

        public bool IsCriticalHit()
        {
            Random random = new Random();
            return random.Next(0, 100) < 10; // 10% chance of critical hit
        }
    }
}
