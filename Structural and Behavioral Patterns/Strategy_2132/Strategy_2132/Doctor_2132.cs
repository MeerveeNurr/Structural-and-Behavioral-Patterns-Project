using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2132
{
    public class Doctor_2132
    {
        public string Name { get; set; }

        public Doctor_2132(string name)
        {
            Name = name;
        }

        public void AssignTreatment(Patient_2132 patient, HospitalStrategy_2132 strategy)
        {
            patient.TreatmentStrategy = strategy;
            Console.WriteLine($"Doctor {Name} assigned {strategy.GetType().Name} strategy to patient {patient.Name}.");
        }
    }

}
