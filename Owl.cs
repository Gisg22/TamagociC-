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
            weapon = new Weapon("Claws");
            weapon.Damage = 50;
            IntinialHealth = 120;
            Health = 120;
        }
        public Owl(string name) : base(name)
        {
            Name = name;
            weapon = new Weapon("Claws");
            weapon.Damage = 50;
            IntinialHealth = 120;
            Health = 120;
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
