﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Character
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public Class? Class { get; set; } 
        public int Str_mod { get; set; }
        public int Dex_mod { get; set; }
        public int Con_mod { get; set; }
        public int Int_mod { get; set; }
        public int Wis_mod { get; set; }
        public int Cha_mod { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int speed { get; set; }
        public Background? background { get; set; }
        public Ancestry? ancestry { get; set; }

        //public List<Attack_rolls> attack_Rolls { get; set; }

        public List<Equipment>? equipment { get; set; }

        // private List<Skill> skills { get; set; }

        public List<Feat>? feats { get; set; }

        public List<Spell>? spells { get; set; }

        public List<String>? Languages { get; set; }

        public int id_abilityScores { get; set; }
        
        public override string ToString()
        {
            return name; // Para exibir o nome na lista
        }
    }
}
