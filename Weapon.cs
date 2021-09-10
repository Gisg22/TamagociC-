using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Weapon : Item
    {
        public Weapon() : base() { }
        public Weapon(string name) : base(name) {
            Name = name;
        }
        public int Damage { get; set; }
    }
}
