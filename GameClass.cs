using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public class GameClass
    {
        public int level {  get; set; }
        public string Description { get; set; }                       // Opis klasy (nowe pole)
        public string Name { get; set; }                    // Np. "Wizard"
        public int HitDie { get; set; }                     // Np. 6, 8, 10, 12
        public string PrimaryStat { get; set; }             // Np. "Intelligence"
        public List<string> SavingThrows { get; set; }      // Np. ["Dexterity", "Intelligence"]
        public List<string> Proficiencies { get; set; }     // Np. ["Arcana", "History"]
        public List<string> Abilities { get; set; }         // Np. ["Arcane Recovery", "Spellcasting"]
        public int BaseSpeedModifier { get; set; }          // Np. 0, +5 (opcjonalne)
        public Dictionary<string, int> StatBonuses { get; set; } // Np. {"Wisdom": 1}


    }
}
