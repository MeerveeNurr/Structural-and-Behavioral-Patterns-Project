using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2132
{
    internal class Appointment_2132 : IComposite_2132
    {
        private DateTime _date;
        private Doctor_2132 _doctor;
        private Patient_2132 _patient;

        public Appointment_2132(DateTime date, Doctor_2132 doctor, Patient_2132 patient)
        {
            _date = date;
            _doctor = doctor;
            _patient = patient;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Appointment Date: {_date}, Doctor: {_doctor}, Patient: {_patient}");
        }
    }
}
