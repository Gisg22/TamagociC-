using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Raccoon : Tamagochi
    {
        public Raccoon() : base() {
            weapon = new Weapon("Pistol");
            weapon.Damage = 10;
            IntinialHealth = 150;
            Health = 150;
        }
        public Raccoon(string name) : base(name)
        {
            Name = name;
            weapon = new Weapon("Pistol");
            weapon.Damage = 10;
            IntinialHealth = 150;
            Health = 150;
        }

        public override void AngryTalk()
        {
            Console.WriteLine("RRRRRRRRRRRRR");
        }
        public override void Talk()
        {
            Console.WriteLine("Rrrrr...");
        }
        private Weapon weapon;
}
}
