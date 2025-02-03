using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    internal class Enemy
    {
        List<IDamageable> targets = new List<IDamageable>();
        Random rng;

        public Enemy(Random rng)
        {
            this.rng = rng;
        }

        public void AddTarget(IDamageable target)
        {
            targets.Add(target);
        }

        public void AttackAll()
        {
            foreach (IDamageable target in targets)
            {
                target.TakeDamage(rng.Next(1, 11));
            }
        }

    }
}

