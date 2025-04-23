using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class DoctorFacade_2132
    {
        private List<Doctor_2132> doctors = new List<Doctor_2132>();

        public void AddDoctor(Doctor_2132 doctor)
        {
            doctors.Add(doctor);
            Console.WriteLine($"Doctor {doctor.Name} added.");
        }

        public void RemoveDoctor(Doctor_2132 doctor)
        {
            doctors.Remove(doctor);
            Console.WriteLine($"Doctor {doctor.Name} removed.");
        }
    }
}
