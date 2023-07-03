using System;
using System.Collections.Generic;

namespace Pokemon
{
    // Observer Pattern: Observer interface
    public interface IObserver
    {
        void Update();
    }

    // Observer Pattern: Observable class
    public class Observable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Observer Pattern: Pokemon class acts as the subject that other objects can observe
    public class Pokemon : Observable, IObserver
    {
        public string Name { get; set; }
        private int hp;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                Notify(); // Notify observers when HP changes
            }
        }

        public List<IAttackStrategy> Attacks { get; set; }

        public void DisplayStatus()
        {
            Console.WriteLine($"Pokemon: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine();
        }

        public void PerformAttack(Pokemon target)
        {
            Console.WriteLine($"{Name}'s turn");

            IAttackStrategy attack = GetRandomAttack();
            int damage = attack.CalculateDamage();

            if (attack.IsCriticalHit())
            {
                damage *= 2; // Critical hit doubles the damage
                Console.WriteLine("Critical Hit!");
            }

            target.HP -= damage;

            Console.WriteLine($"{Name} used {attack.GetType().Name}");
            Console.WriteLine($"{target.Name} lost {damage} HP");
            Console.WriteLine();
        }

        private IAttackStrategy GetRandomAttack()
        {
            Random random = new Random();
            int index = random.Next(0, Attacks.Count);
            return Attacks[index];
        }

        public void Update()
        {
            // Handle the update when HP changes
            Console.WriteLine($"Observable: {Name}'s HP has changed to {HP}");
        }
    }
}
