using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Player : IDoWithTamagochi
    {
       public Player() { }
        public Player(string name) {
            Name = name;
            weapon = new Weapon("Booom!")
            {
                Damage = 30
            };

            food = new Food("Corn")
            {
                Health = 30
            };
           
            Health = 200;
        }
        public int Health { get; set; }
        public string Name { get; set; }
        public void FeedTamagochi(Tamagochi tamagochi)
        {
            if (tamagochi.Health < tamagochi.IntinialHealth)
            {
                tamagochi.Health += food.Health;
                if (tamagochi.Health > tamagochi.IntinialHealth)
                {
                    tamagochi.Health = tamagochi.IntinialHealth;
                }
                tamagochi.Happy++;
            }
            else
            {
                tamagochi.Health = tamagochi.IntinialHealth;
            }
        }

        public void DamageTamagochi(Tamagochi tamagochi)
        {
            tamagochi.Health -= weapon.Damage;
            tamagochi.Happy--;

        }

        public void StorkeTamagochi(Tamagochi tamagochi)
        {
            tamagochi.Happy++;
        }

        private readonly Weapon weapon;
        private readonly Food food;
    }
}
