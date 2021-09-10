using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    interface IDoWithTamagochi
    {
        void DamageTamagochi(Tamagochi tamagochi);
        void FeedTamagochi(Tamagochi tamagochi);

        void StorkeTamagochi(Tamagochi tamagochi);
    }
}
