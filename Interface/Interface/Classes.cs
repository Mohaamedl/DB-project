using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Classes
    {
        public string name {  get; set; }
        public int HP { get; set; }
        public string prof_attack { get; set; }
        public string prof_saving_throws { get; set; }

        public string prof_perception { get; set; }
        public string prof_defense { get; set; }
        public string prof_classDC { get; set; }
        public string ability { get; set; }
         public int progression_level { get; set; }
        public string progression_class_features { get; set; }
        public override string ToString()
        {
            return "( " +name+")";
        }

    }
   
}
