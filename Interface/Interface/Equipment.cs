using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Equipment
    {
        public string name ; public int id; public int quantity;
        public string item_category {  get; set; }
        public string item_sub_category { get; set; }
        public string usage { get; set; }
        public string bulk {  get; set; }
        public string rarity { get; set; }
        public string weapon_category { get; set; }
        public int level { get; set; }
        public int price { get; set; }

    }
}
