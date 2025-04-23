using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2132
{
    public class Patient_2132
    {
        public string Name { get; set; }
        public HospitalStrategy_2132 TreatmentStrategy { get; set; }

        public Patient_2132(string name)
        {
            Name = name;
        }

        public void ApplyTreatment()
        {
            TreatmentStrategy.Apply(this);
        }
    }
}
