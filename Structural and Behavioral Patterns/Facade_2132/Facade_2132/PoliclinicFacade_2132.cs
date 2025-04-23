using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class PoliclinicFacade_2132  
    {
        private List<Policlinic_2132> polyclinics = new List<Policlinic_2132>();

        public void AddPolyclinic(Policlinic_2132 polyclinic)
        {
            polyclinics.Add(polyclinic);
            Console.WriteLine($"Required Polyclinic {polyclinic.Name} added.");
        }

        public void RemovePolyclinic(Policlinic_2132 polyclinic)
        {
            polyclinics.Remove(polyclinic);
            Console.WriteLine($" Required Polyclinic {polyclinic.Name} removed.");
        }
    }
}
