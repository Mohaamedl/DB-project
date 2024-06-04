using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Background
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string ability { get; set; }
        public string skill { get; set; }
        public string feat { get; set; }
        public string rarity { get; set; }
        public string summary { get; set; }


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Background() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public Background( string name, string ability, string skill, string feat, string rarity, string summary)
        {
            
            this.name = name;
            this.ability = ability;
            this.skill = skill;
            this.feat = feat;
            this.rarity = rarity;
            this.summary = summary;
        }

        
        public override string ToString()
        {
            return $"Name: {name}, Ability: {ability}, Skill: {skill}, Feat: {feat}, Rarity: {rarity}, Summary: {summary}";
        }

    }
}
