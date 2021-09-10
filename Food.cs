using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Food : Item
    {
        public Food() : base() { }
        public Food(string name) : base(name) {
            Name = name;
        }
        
       public int Health { get; set; }

    }
}
