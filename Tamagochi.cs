using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
   abstract class Tamagochi
    {
        public Tamagochi() { }
       public Tamagochi(string name) {
            Name = name;
        }
        public abstract void Talk();
        public abstract void AngryTalk();

        public void AttackPlayer(Player player)
        {
            player.Health -= weapon.Damage;
        }
        public Weapon weapon { get; set; }
        public string Name { get; set; }
        public int Health { set; get; }
        public int Happy { get; set; }

        public int Bool { get; set; }

        public int IntinialHealth { get; set; }
    }
}
