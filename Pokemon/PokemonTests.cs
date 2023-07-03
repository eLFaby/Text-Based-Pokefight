using NUnit.Framework;
using Pokemon;

namespace PokemonTests
{
    [TestFixture]
    public class PokemonTests
    {
        [Test]
        public void PerformAttack_ReducesTargetHP()
        {
            Pokemon.Pokemon attacker = new Pokemon.Pokemon
            {
                Name = "Gengar",
                HP = 100,
                Attacks = new List<IAttackStrategy>
                {
                    new Attack { Name = "Shadow Ball", MinDamage = 10, MaxDamage = 20 }
                }
            };

            Pokemon.Pokemon defender = new Pokemon.Pokemon
            {
                Name = "Raichu",
                HP = 100,
                Attacks = new List<IAttackStrategy>
                {
                    new Attack { Name = "Thunder Punch", MinDamage = 5, MaxDamage = 15 }
                }
            };

            int initialHP = defender.HP;
            attacker.PerformAttack(defender);
            int finalHP = defender.HP;

            Assert.That(finalHP, Is.LessThan(initialHP));
        }
    }
}
