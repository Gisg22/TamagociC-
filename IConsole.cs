using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    interface IConsoleTamagochi
    {
        public void MenuConsole();
        public void Play();
        public void CreateTamagochi(ref Tamagochi tamagochi);

        public void Process(ref Tamagochi tamagochi);

        public void FightWithMage(Tamagochi tamagochi);
    }
}
