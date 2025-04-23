using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Command_2132
{
    public class Appointment_2132
    {
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public Doctor_2132 Doctor { get; set; }
        public Patient_2132 Patient { get; set; }

        public Appointment_2132(string details, DateTime date, Doctor_2132 doctor, Patient_2132 patient)
        {
            Details = details;
            Date = date;
            Doctor = doctor;
            Patient = patient;
        }
    }
}
