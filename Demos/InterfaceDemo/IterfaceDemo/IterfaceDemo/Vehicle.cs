using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    internal class Vehicle : IDamageable
    {
        // Fields
        private int damage;
        private String type;

        // Properties
        public int CurrentDamage { get { return damage; } }

        // Constructor
        public Vehicle(String model)
        {
            this.type = model;
            damage = 0;
        }

        public void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                damage += amount;
            }
            Console.WriteLine(type + " has taken " + damage + " total damage");
        }
    }

}
