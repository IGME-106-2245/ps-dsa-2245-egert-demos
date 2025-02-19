using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Player
    {
        public string Name { get; set; }

        public Player()
        {
            Name = "Bob";
        }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
