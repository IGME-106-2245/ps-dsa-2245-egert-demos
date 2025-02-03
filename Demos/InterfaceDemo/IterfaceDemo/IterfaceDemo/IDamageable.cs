using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    internal interface IDamageable
    {
        // Gets the amount of damage that has been
        // done to the object so far
        int CurrentDamage { get; }

        // Applies new damage to the object
        void TakeDamage(int amount);
    }
}
