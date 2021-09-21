using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Mage : ICreatureProperties
    {
        public Mage()
        {

        }
        public Mage(string name)
        {
            Name = name;
            Health = 10000000;
            Weapon = new("Ядовитые грибы.");
            Weapon.Damage = 50;
            Lenses = true;
        }
        public string Name { get; set; }
        public int Health { get ; set; }
        public Weapon Weapon { get; set; }
        public bool Lenses { get; set; }

        public DateTime ArrivalDate { get; set; } = new DateTime(2021, 1, 18);
        public void AngryTalk()
        {
            Console.WriteLine("Kalter malter bruner kniter!");
        }

        public void Talk()
        {
            if (Health <= 0)
            {
                Console.WriteLine("This animal, too, can only devour! Except that you don't hit her.");
            }

        }

        public void AttackPlayerAndTamagochi(Tamagochi tamagochi, Player player)
        {
            tamagochi.Health -= Weapon.Damage;
            player.Health -= Weapon.Damage;
            tamagochi.Happy--;
        }
    }
}
