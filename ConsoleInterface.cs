using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Tamagochi
{
    class ConsoleInterfaceTamagochi : IConsoleTamagochi
    {
        public void MenuConsole()
        {
                Console.WriteLine("1.Play in Tamagochi.");
                Console.WriteLine("2.Exit.");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    Play();
                        break;
                    default:
                        Console.WriteLine("Your choice is incorrect. Please, enter 1 or 2.");
                        break;
                }
        }

        public void CreateTamagochi(ref Tamagochi tamagochi)
        {
            Console.WriteLine("Input name Player:");
            string name_player = Console.ReadLine();
            player = new(name_player);
            Console.WriteLine($"Hello, {player.Name}.");
            Console.WriteLine("Okey, input name Tamagochi:");
            string name_tamagochi = Console.ReadLine();
            tamagochi.Name = name_tamagochi;
            Console.WriteLine("Save to file...");
        }



        public void Play()
        {
            random = new Random();
            raccon = new Raccoon();
            owl = new Owl();
            
            int num = random.Next(1, 3);
            if (num == 1)
            {
                CreateTamagochi(ref owl);
                Process(ref owl);
                
            }
            else if (num == 2)
            {
                CreateTamagochi(ref raccon);
                Process(ref raccon);

            }
            
        }

        public void Process(ref Tamagochi tamagochi)
        {
            if (mage.ArrivalDate == DateTime.Today)
            {
                FightWithMage(tamagochi);
            }
            else
            {
                int choise;
                Console.WriteLine($"Tamagochi date time: {tamagochi.DateRegistration }");
                do
                {
                    Console.WriteLine($"1.Feed this is {tamagochi.Name}.");
                    Console.WriteLine($"2.Damage this is {tamagochi.Name}.");
                    Console.WriteLine($"3.Stroke this is {tamagochi.Name}.");
                    Console.WriteLine("4 and bigger.Exit");
                    Console.WriteLine($"Kind of tamagochi: {tamagochi.Kind}");
                    Console.WriteLine($"My health: {player.Health}");
                    Console.WriteLine($"Tamagochi health: {tamagochi.Health}");
                    Console.WriteLine($"Tamagochi name: {tamagochi.Name}.");
                    Console.WriteLine($"Tamagochi mood level: {tamagochi.Happy}.");
                    choise = int.Parse(Console.ReadLine());
                    if (choise == 1)
                    {
                        Console.WriteLine($"Eat: {player.Food.Name}.");
                        player.FeedTamagochi(tamagochi);

                    }
                    else if (choise == 2)
                    {
                        Console.WriteLine($"My weapon: {player.Weapon.Name}.");
                        Console.WriteLine($"Weapon of tamagochi: {tamagochi.Weapon.Name}.");
                        player.DamageTamagochi(tamagochi);
                        tamagochi.AttackPlayer(player);
                        tamagochi.AngryTalk();

                    }
                    else if (choise == 3)
                    {
                        player.StorkeTamagochi(tamagochi);
                    }
                    else
                    {
                        Console.WriteLine("You got out.");
                    }
                } while (tamagochi.Health != 0 && player.Health != 0 && tamagochi.Happy != -10 && choise != 4);
            }
        }

        public void FightWithMage(Tamagochi tamagochi)
        {
            
            Console.WriteLine($"Came to you {mage.Name}...");
            Console.WriteLine( $"{mage.Name}:");
            mage.AngryTalk();

            do
            {
                Console.WriteLine($"Magician attacks you and your tamagochi with weapon {mage.Weapon.Name}...");
                Thread.Sleep(2000);
                mage.AttackPlayerAndTamagochi(tamagochi, player);
                Console.WriteLine($"My health: {player.Health}");
                Console.WriteLine($"Tamagochi health: {tamagochi.Health}");
                Console.WriteLine($"Health of mage: {mage.Health}");
                Console.WriteLine("Choose where to attack:");
                Console.WriteLine("1.Stomach");
                Console.WriteLine("2.Eyes");
                Console.WriteLine("3.Lep.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                  
                  case 2:
                        mage.Lenses = false;
                        player.AttackMage(mage);
                        Console.WriteLine("You win!");
                        break;
                    default:
                        Console.WriteLine("He doesn't care...");
                        break;
                }
                
            } while (tamagochi.Health != 0 && player.Health != 0 && tamagochi.Happy != -10 && mage.Health != 0);
        }

        private int choice;
        private Random random;
        Tamagochi raccon;
        Tamagochi owl;
        Player player;
        Mage mage = new("angry mage - Charly");
    }
}
