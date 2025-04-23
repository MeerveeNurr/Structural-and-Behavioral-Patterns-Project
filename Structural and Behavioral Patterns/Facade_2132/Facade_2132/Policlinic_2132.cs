using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class Policlinic_2132
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Policlinic_2132(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
