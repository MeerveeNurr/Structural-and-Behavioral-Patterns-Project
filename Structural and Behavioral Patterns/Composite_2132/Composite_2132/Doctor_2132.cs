using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2132
{
    internal class Doctor_2132 : IComposite_2132
    {
        private string _name;
        private string _specialty;

        public Doctor_2132(string name, string specialty)
        {
            _name = name;
            _specialty = specialty;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Doctor: {_name}, Specialty: {_specialty}");
        }
    }
}
