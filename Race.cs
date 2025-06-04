using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public class Race
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, int> StatBonuses { get; set; }
        public List<string> Immunities { get; set; }
    }

}
