using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Background
    {
        public string name { get; set; }
        public string ability { get; set; }
        public string skill { get; set; }
        public string feat { get; set; }
        public string rarity { get; set; }
        public string summary { get; set; }

        
        public Background() { }

        public Background( string name, string ability, string skill, string feat, string rarity, string summary)
        {
            
            name = name;
            ability = ability;
            skill = skill;
            feat = feat;
            rarity = rarity;
            summary = summary;
        }

        
        public override string ToString()
        {
            return $"Name: {name}, Ability: {ability}, Skill: {skill}, Feat: {feat}, Rarity: {rarity}, Summary: {summary}";
        }

    }
}
