using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_2132
{
    public class CancelAppointment_2132 : ICommand_2132
    {
        private Appointment_2132 _appointment;
        private HospitalCommand_2132 _system;

        public CancelAppointment_2132(Appointment_2132 appointment, HospitalCommand_2132 system)
        {
            _appointment = appointment;
            _system = system;
        }

        public void Execute()
        {
            _system.CancelAppointment(_appointment);
            Console.WriteLine("Appointment cancelled: " + _appointment.Details);
        }

        public void Revoke()
        {
            _system.CreateAppointment(_appointment);
            Console.WriteLine("Appointment created: " + _appointment.Details);
        }
    }

}
