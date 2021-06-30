using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectComposition.Entities
{
    class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Departament()
        {
        }

        public Departament(string name)
        {
            Name = name;
        }
    }
}
