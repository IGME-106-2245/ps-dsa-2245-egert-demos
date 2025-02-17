using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Player
    {
        private string name;

        public Player()
        {
            name = "Bob";
        }

        public Player(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name; 
        }
    }
}
