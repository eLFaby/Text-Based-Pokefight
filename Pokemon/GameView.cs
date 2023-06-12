using System;

namespace Pokemon
{
    public static class GameView
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayPokemonStatus(Pokemon pokemon)
        {
            Console.WriteLine($"Pokemon: {pokemon.Name}");
            Console.WriteLine($"HP: {pokemon.HP}");
            Console.WriteLine();
        }

        public static void DisplayAttackOptions(List<Attack> attacks)
        {
            Console.WriteLine("Select an attack: ");
            for (int i = 0; i < attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {attacks[i].Name}");
            }
            Console.WriteLine();
        }

        public static int GetAttackChoice()
        {
            Console.Write("Enter your choice: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
