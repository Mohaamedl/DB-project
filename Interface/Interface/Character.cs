using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public string Class { get; set; } // Adicional, como exemplo

        public override string ToString()
        {
            return Name; // Para exibir o nome na lista
        }
    }
}
