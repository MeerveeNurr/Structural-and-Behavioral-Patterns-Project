using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class AppointmentFacade_2132
    {
        private List<Appointment_2132> appointments = new List<Appointment_2132>();

        public void AddAppointment(Appointment_2132 appointment)
        {
            appointments.Add(appointment);
            Console.WriteLine($"Appointment for {appointment.Patient.Name} with Dr. {appointment.Doctor.Name} added.");
        }

        public void RemoveAppointment(Appointment_2132 appointment)
        {
            appointments.Remove(appointment);
            Console.WriteLine($"Appointment for {appointment.Patient.Name} with Dr. {appointment.Doctor.Name} removed.");
        }
    }
}
