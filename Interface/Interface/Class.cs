using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Class
    {
        public int ID { get; set; }
        public string name {  get; set; }
        public int HP { get; set; }
        public string prof_attack { get; set; }
        public string prof_defense { get; set; }
        public string ability { get; set; }
         public int spell_progression_id { get; set; }
        public override string ToString()
        {
            return "( " +name+")";
        }

    }
   
}
