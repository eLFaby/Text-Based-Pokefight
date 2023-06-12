using System;
using System.Collections.Generic;

namespace Pokemon
{
    public class GameController
    {
        private Pokemon gengar;
        private Pokemon raichu;

        public void StartGame()
        {
            InitializePokemon();

            while (gengar.HP > 0 && raichu.HP > 0)
            {
                GameView.DisplayPokemonStatus(gengar);
                GameView.DisplayPokemonStatus(raichu);

                PlayerTurn(gengar, raichu);
                if (raichu.HP > 0)
                {
                    PlayerTurn(raichu, gengar);
                }
            }

            GameView.DisplayMessage("Game Over!");
            if (gengar.HP <= 0)
            {
                GameView.DisplayMessage("Raichu wins!");
            }
            else if (raichu.HP <= 0)
            {
                GameView.DisplayMessage("Gengar wins!");
            }
        }

        private void PlayerTurn(Pokemon attacker, Pokemon defender)
        {
            GameView.DisplayMessage($"{attacker.Name}'s turn");

            GameView.DisplayAttackOptions(attacker.Attacks);
            int choice = GameView.GetAttackChoice();

            Attack attack = attacker.Attacks[choice - 1];
            int damage = GameMechanics.CalculateDamage(attack.MinDamage, attack.MaxDamage);

            if (GameMechanics.IsCriticalHit())
            {
                damage *= 2; // Critical hit doubles the damage
                GameView.DisplayMessage("Critical Hit!");
            }

            defender.HP -= damage;

            GameView.DisplayMessage($"{attacker.Name} used {attack.Name}");
            GameView.DisplayMessage($"{defender.Name} lost {damage} HP");

            GameView.DisplayMessage("Next Turn!");
        }

        private void InitializePokemon()
        {
            // Create Gengar
            gengar = new Pokemon
            {
                Name = "Gengar",
                HP = 100,
                Attacks = new List<Attack>
                {
                    new Attack { Name = "Shadow Ball", MinDamage = 3, MaxDamage = 13 },
                    new Attack { Name = "Sludge Bomb", MinDamage = 1, MaxDamage = 18 },
                    new Attack { Name = "Focus Blast", MinDamage = 5, MaxDamage = 27 }
                }
            };

            // Create Raichu
            raichu = new Pokemon
            {
                Name = "Raichu",
                HP = 100,
                Attacks = new List<Attack>
                {
                    new Attack { Name = "Thunder Punch", MinDamage = 5, MaxDamage = 10 },
                    new Attack { Name = "Brick Break", MinDamage = 8, MaxDamage = 14 },
                    new Attack { Name = "Wild Charge", MinDamage = 1, MaxDamage = 35 }
                }
            };
        }
    }
}
