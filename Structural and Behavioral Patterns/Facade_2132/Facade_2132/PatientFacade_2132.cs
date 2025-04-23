using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class PatientFacade_2132
    {
        private List<Patient_2132> patients = new List<Patient_2132>();

        public void AddPatient(Patient_2132 patient)
        {
            patients.Add(patient);
            Console.WriteLine($"Reqired Patient {patient.Name} added.");
        }

        public void RemovePatient(Patient_2132 patient)
        {
            patients.Remove(patient);
            Console.WriteLine($" Required Patient {patient.Name} removed.");
        }
    }
}
