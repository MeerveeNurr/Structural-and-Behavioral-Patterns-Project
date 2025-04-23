using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_2132
{
    public class AddPatient_2132 : ICommand_2132
    { 
            private Patient_2132 _patient;
            private HospitalCommand_2132 _system;

            public AddPatient_2132(Patient_2132 patient, HospitalCommand_2132 system)
            {
                _patient = patient;
                _system = system;
            }

            public void Execute()
            {
                _system.AddPatient(_patient);
                Console.WriteLine("Required Patient Added : " + _patient.Name);
            }

            public void Revoke()
            {
                _system.RemovePatient(_patient);
                Console.WriteLine("Required Patient Removed: " + _patient.Name);
            }
        }

    }
