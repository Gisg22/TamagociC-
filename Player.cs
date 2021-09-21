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
            Weapon = new Weapon("Club")
            {
                Damage = 30
            };

            Food = new Food("Corn")
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
                tamagochi.Health += Food.Health;
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
            tamagochi.Health -= Weapon.Damage;
            tamagochi.Happy--;

        }

        public void StorkeTamagochi(Tamagochi tamagochi)
        {
            tamagochi.Happy++;
        }

        public void AttackMage(Mage mage)
        {
            if (!mage.Lenses)
            {
                mage.Health = 0;
            }
        }

    public Weapon Weapon { get; set; }
    public Food Food { get; set; }
    }
}
