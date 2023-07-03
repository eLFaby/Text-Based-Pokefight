using System;

namespace Pokemon
{
    // Singleton Pattern: GameController class ensures only one instance is created
    // The private constructor and the Instance property provide access to the single instance of the GameController class.
    public class GameController
    {
        private static GameController instance;
        private Pokemon gengar;
        private Pokemon raichu;
        public Pokemon Gengar
        {
            get { return gengar; }
            set { gengar = value; }
        }

        public Pokemon Raichu
        {
            get { return gengar; }
            set { gengar = value; }
        }

        public bool GameOver { get; private set; }
        private GameController()
        {
            // Pokemon initialization
            gengar = new Pokemon
            {
                Name = "Gengar",
                HP = 100,
                Attacks = new List<IAttackStrategy>
                {
                    new Attack { Name = "Shadow Ball", MinDamage = 3, MaxDamage = 13 },
                    new Attack { Name = "Sludge Bomb", MinDamage = 1, MaxDamage = 18 },
                    new Attack { Name = "Focus Blast", MinDamage = 5, MaxDamage = 27 }
                }
            };

            raichu = new Pokemon
            {
                Name = "Raichu",
                HP = 100,
                Attacks = new List<IAttackStrategy>
                {
                    new Attack { Name = "Thunder Punch", MinDamage = 5, MaxDamage = 10 },
                    new Attack { Name = "Brick Break", MinDamage = 8, MaxDamage = 14 },
                    new Attack { Name = "Wild Charge", MinDamage = 1, MaxDamage = 35 }
                }
            };
        }

        public static GameController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameController();
                }
                return instance;
            }
        }

        public void StartGame()
        {
            while (gengar.HP > 0 && raichu.HP > 0)
            {
                gengar.DisplayStatus();
                raichu.DisplayStatus();

                gengar.PerformAttack(raichu);
                if (raichu.HP > 0)
                {
                    raichu.PerformAttack(gengar);
                }
            }

            Console.WriteLine("Game Over!");
            if (gengar.HP <= 0)
            {
                GameOver = true;
                Console.WriteLine("Raichu wins!");
            }
            else if (raichu.HP <= 0)
            {
                GameOver = true;
                Console.WriteLine("Gengar wins!");
            }

            
        }
    }
}
