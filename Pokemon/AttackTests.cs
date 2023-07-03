using NUnit.Framework;
using Pokemon;

namespace PokemonTests
{
    [TestFixture]
    public class AttackTests
    {
        [Test]
        public void CalculateDamage_ReturnsValidDamage()
        {
            Attack attack = new Attack
            {
                MinDamage = 5,
                MaxDamage = 10
            };

            int damage = attack.CalculateDamage();

            Assert.That(damage, Is.InRange(5, 10));
        }

        [Test]
        public void IsCriticalHit_ReturnsTrueOrFalse()
        {
            Attack attack = new Attack();

            bool isCriticalHit = attack.IsCriticalHit();

            Assert.That(isCriticalHit, Is.TypeOf<bool>());
        }
    }
}
