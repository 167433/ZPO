using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public abstract class Character
    {
        protected int Strength { get; set; }
        protected int Wisdom { get; set; }
        protected int Charisma { get; set; }
        protected int Dexterity { get; set; }
        protected int Constitution { get; set; }
        protected int Intelligence { get; set; }

        // Prędkość i punkty życia – mogą być nadpisane
        protected int Speed { get; set; }
        protected int HitPoints { get; set; }
        protected int proficencyBonus { get; set; }

        protected string race {  get; set; }

    }
}
