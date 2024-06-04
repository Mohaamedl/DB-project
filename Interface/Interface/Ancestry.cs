using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Interface
{
    public class Ancestry
    {
        public int ID {  get; set; }
        public string name { get; set; }
        public string vision { get; set; }
        public string size { get; set; }
        public int speed { get; set; }
        public int HP { get; set; }
        public string rarity { get; set; }
        public string ability_flaw { get; set; }
        public string ability_boost { get; set; }

        public Ancestry()
        {
        }



        public Ancestry(string name, string vision, string size, int speed, int hp, string rarity, string ability_flaw, string ability_boost)
        {
            this.name = name;
            this.vision = vision;
            this.size = size;
            this.speed = speed;
            this.HP = hp;
            this.rarity = rarity;
            this.ability_flaw = ability_flaw;
            this.ability_boost = ability_boost;
        }

        public override string ToString()
        {
            return $"Name: {name}, Vision: {vision}, Size: {size}, Speed: {speed}, HP: {HP}, Rarity: {rarity}, Ability Flaw: {ability_flaw}, Ability Boost: {ability_boost}";
        }
    }
}
