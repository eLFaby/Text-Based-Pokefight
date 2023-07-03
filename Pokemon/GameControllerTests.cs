using NUnit.Framework;
using Pokemon;

namespace PokemonTests
{
    [TestFixture]
    public class GameControllerTests
    {
        [Test]
        public void StartGame_GameOverConditionMet()
        {
            GameController gameController = GameController.Instance;

            // Set initial HP values to test the game over condition
            gameController.Gengar.HP = 0; // Use the Gengar property instead of gengar field
            gameController.Raichu.HP = 50; // Use the Raichu property instead of gengar field

            gameController.StartGame();

            Assert.That(gameController.GameOver, Is.True);
        }
    }
}
