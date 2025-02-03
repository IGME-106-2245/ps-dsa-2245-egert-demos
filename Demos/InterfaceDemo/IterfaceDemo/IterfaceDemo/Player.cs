using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    internal class Player : IDamageable
    {
        // Fields
        private int damage;
        private String name;
        private Random rng;

        // Properties
        public int CurrentDamage { get { return damage; } }

        // Constructor
        public Player(String name, Random rng)
        {
            this.name = name;
            damage = 0;
            this.rng = rng;
        }

        public void TakeDamage(int amount)
        {
            // Player has a 50% chance of dodging
            if (amount > 0 && rng.NextDouble() > 0.5)
            {
                damage += amount;
                Console.WriteLine(name + " has taken " + damage + " total damage");
            }
            else
            {
                Console.WriteLine(name +
                   " evades this attack and survives with only their prior damage of " + damage);
            }
        }
    }
}
