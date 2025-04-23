using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_2132
{
    public class AddPoliclinic_2132 : ICommand_2132
    {
            private Policlinic_2132 _clinic;
            private HospitalCommand_2132 _system;

            public AddPoliclinic_2132(Policlinic_2132 clinic, HospitalCommand_2132 system)
            {
                _clinic = clinic;
                _system = system;
            }

            public void Execute()
            {
                _system.AddPoliclinic(_clinic);
                Console.WriteLine("Required Policlinic Added: " + _clinic.Name);
            }

            public void Revoke()
            {
                _system.RemovePoliclinic(_clinic);
                Console.WriteLine("Required policlinic Removed: " + _clinic.Name);
            }
        }

    }
