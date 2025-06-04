using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public class NPC: Character
    {
        public List<string> Resistances { get; set; } = new List<string>();
        public List<string> Immunities { get; set; } = new List<string>();
        public  List<string> Skills { get; set; } = new List<string>();
        public  List<string> Notes { get; set; } = new List<string>();

        public NPC(int str = 2)
        {
            this.Strength = str;
        }
    }
}
