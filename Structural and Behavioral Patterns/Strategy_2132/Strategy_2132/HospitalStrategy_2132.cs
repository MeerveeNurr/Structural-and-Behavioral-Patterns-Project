using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2132
{
    public abstract class HospitalStrategy_2132
    {
        public abstract void Apply(Patient_2132 patient);
    }

    public class MedicationTreatment : HospitalStrategy_2132
    {
        public override void Apply(Patient_2132 patient)
        {
            Console.WriteLine($"Applying medication treatment to patient {patient.Name}.");
        }
    }

    public class Physiotherapy : HospitalStrategy_2132
    {
        public override void Apply(Patient_2132 patient)
        {
            Console.WriteLine($"Applying physiotherapy to patient {patient.Name}.");
        }
    }

    public class Surgery : HospitalStrategy_2132
    {
        public override void Apply(Patient_2132 patient)
        {
            Console.WriteLine($"Performing surgery on patient {patient.Name}.");
        }
    }
    public class Chemotherapy : HospitalStrategy_2132
    {
        public override void Apply(Patient_2132 patient)
        {
            Console.WriteLine($"Performing chemotherapy on patient {patient.Name}.");
        }
    }

}