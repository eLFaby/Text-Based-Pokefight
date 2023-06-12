using System.Collections.Generic;

namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public List<Attack> Attacks { get; set; }
    }
}
