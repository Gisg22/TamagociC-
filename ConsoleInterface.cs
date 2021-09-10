using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void CreateTamagochi(ref Tamagochi tamagochi, ref Player player)
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
            Tamagochi raccon = new Raccoon();
            Tamagochi owl = new Owl();
            Player player = new();
            
            int num = random.Next(1, 2);
            if (num == 1)
            {
                CreateTamagochi(ref owl, ref player);
                Process(ref owl, ref player);
                
            }
            else if (num == 2)
            {
                CreateTamagochi(ref raccon, ref player);
                Process(ref raccon, ref player);

            }
            
        }

        public void Process(ref Tamagochi tamagochi, ref Player player)
        {
            int close = 0;
            do
            {
                Console.WriteLine($"1.Feed this is {tamagochi.Name}.");
                Console.WriteLine($"2.Damage this is {tamagochi.Name}.");
                Console.WriteLine($"3.Stroke this is {tamagochi.Name}.");
                Console.WriteLine("4.Exit");
                Console.WriteLine($"My health: {player.Health }");
                Console.WriteLine($"Tamagochi health: {tamagochi.Health }");
                Console.WriteLine($"Tamagochi name: {tamagochi.Name }");
                Console.WriteLine($"Tamagochi mood level: {tamagochi.Happy }");
                close = int.Parse(Console.ReadLine());
                if (close == 1)
                {
                    player.FeedTamagochi(tamagochi);

                }
                else if (close == 2)
                {
                    player.DamageTamagochi(tamagochi);
                    tamagochi.AttackPlayer(player);
                    tamagochi.AngryTalk();
                    //break;
                }
                else if (close == 3)
                {
                    player.StorkeTamagochi(tamagochi);

                }
                else
                {
                    Console.WriteLine("Your choice is incorrect. Please, enter 1, 2 of 3.");
                }
                } while (tamagochi.Health != 0 && player.Health != 0 && tamagochi.Happy != 0 && close != 4);

        }

        private int choice;
        private Random random;
    }
}
