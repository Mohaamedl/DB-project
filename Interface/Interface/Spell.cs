using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Spell
    {
        public int ID { get; set; }
        public string SpellType { get; set; }
        public string Name { get; set; }
        public string Actions { get; set; }
        public string Defense { get; set; }
        public string Target { get; set; }
        public string Rarity { get; set; }
        public string Trigger { get; set; }
        public string Area { get; set; }
        public int Rank { get; set; }
        public string Heighten { get; set; }
        public string Duration { get; set; }
        public string Range { get; set; }
        public Spell() { }

        // Construtor com parâmetros para inicializar todas as propriedades
        public Spell(int id, string spellType, string name, string actions, string defense, string target, string rarity, string trigger, string area, int rank, string heighten, string duration, string range)
        {
            ID = id;
            SpellType = spellType;
            Name = name;
            Actions = actions;
            Defense = defense;
            Target = target;
            Rarity = rarity;
            Trigger = trigger;
            Area = area;
            Rank = rank;
            Heighten = heighten;
            Duration = duration;
            Range = range;
        }
    }
}
