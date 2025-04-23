using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_2132
{
    public class Doctor_2132
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Doctor_2132(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }
    }
}
