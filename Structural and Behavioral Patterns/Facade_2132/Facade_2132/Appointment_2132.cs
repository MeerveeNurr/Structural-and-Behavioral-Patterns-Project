using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class Appointment_2132
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor_2132 Doctor { get; set; }
        public Patient_2132 Patient { get; set; }

        public Appointment_2132(int id, DateTime date, Doctor_2132 doctor, Patient_2132 patient)
        {
            Id = id;
            Date = date;
            Doctor = doctor;
            Patient = patient;
        }
    }
}

