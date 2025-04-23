using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_2132
{
    public class RemoveDoctor_2132 : ICommand_2132
    {
            private Doctor_2132 _doctor;
            private HospitalCommand_2132 _system;

            public RemoveDoctor_2132(Doctor_2132 doctor, HospitalCommand_2132 system)
            {
                _doctor = doctor;
                _system = system;
            }

            public void Execute()
            {
                _system.RemoveDoctor(_doctor);
                Console.WriteLine("Required Doctor Removed: " + _doctor.Name);
            }

            public void Revoke()
            {
                _system.AddDoctor(_doctor);
                Console.WriteLine("Required Doctor Added: " + _doctor.Name);
            }
        }

    }
