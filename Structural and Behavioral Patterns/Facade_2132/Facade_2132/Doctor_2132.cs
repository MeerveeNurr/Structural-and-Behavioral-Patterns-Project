using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class Doctor_2132
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string Specialty { get; set; }

        public Doctor_2132(int id, string name, string specialty)
        {
            Id = id;
            Name = name;
           // Specialty = specialty;
        }
    }
}
