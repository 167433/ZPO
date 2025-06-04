using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO
{
    public class BackStory
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public BackStory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
