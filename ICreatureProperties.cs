using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    interface ICreatureProperties
    {
        public abstract void Talk();
        public abstract void AngryTalk();
        public string Name { get; set; }
        public int Health { set; get; }

        public Weapon Weapon { get; set; }
    }
}
