using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
   abstract class Tamagochi : ICreatureProperties
    {
        public Tamagochi() {
            DateRegistration = DateTime.Now;
        }
       public Tamagochi(string name) {
            Name = name;
            DateRegistration = DateTime.Now;
        }
        public abstract void Talk();
        public abstract void AngryTalk();

        public void AttackPlayer(Player player)
        {
            if (Happy < 0)
            {
                player.Health -= Weapon.Damage;
                
            }
        }
        public Weapon Weapon { get; set; }
        public string Name { get; set; }
        public int Health { set; get; }
        public int Happy { get; set; } = 1;

        public string Kind { get; set; }
        public int Bool { get; set; }

        public int IntinialHealth { get; set; }
        public DateTime DateRegistration { get; set; }
    }
}
