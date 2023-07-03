using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gameController = GameController.Instance;
            gameController.StartGame();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
