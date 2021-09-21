using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Owl : Tamagochi
    {
        public Owl() : base()
        {
            Weapon = new ("Claws");
            Weapon.Damage = 50;
            IntinialHealth = 120;
            Health = 120;
            Kind = "Owl";
        }
        public Owl(string name) : base(name)
        {
            Name = name;
            Weapon = new ("Claws");
            Weapon.Damage = 50;
            IntinialHealth = 120;
            Health = 120;
            Kind = "Owl";
        }

        public override void AngryTalk()
        {
            Console.WriteLine("WOOOOOOOOF!!!!!!!!!!!");
        }
        public override void Talk()
        {
            Console.WriteLine("Wooof...wooof...");
        }
    }
}
