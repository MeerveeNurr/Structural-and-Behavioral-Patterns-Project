using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_2132
{
    public class Appointment_2132
    {
        public Patient_2132 Patient { get; set; }
        public Doctor_2132 Doctor { get; set; }
        public DateTime Date { get; set; }

        public Appointment_2132(Patient_2132 patient, Doctor_2132 doctor, DateTime date)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
        }
    }
    }
