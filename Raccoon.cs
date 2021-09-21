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
            Weapon = new ("Pistol");
            Weapon.Damage = 10;
            IntinialHealth = 150;
            Health = 150;
            Kind = "Raccoon"; 
        }
        public Raccoon(string name) : base(name)
        {
            Name = name;
            Weapon = new ("Pistol");
            Weapon.Damage = 10;
            IntinialHealth = 150;
            Health = 150;
        }

        public override void AngryTalk()
        {
            Console.WriteLine("PF!PF!PF!PF!PF!");
        }
        public override void Talk()
        {
            Console.WriteLine("Rrrrr...");
        }
}
}
