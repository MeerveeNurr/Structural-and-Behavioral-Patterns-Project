using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_2132
{
    public class RemovePoliclinic_2132 : ICommand_2132
    {
        private Policlinic_2132 _clinic;
        private HospitalCommand_2132 _system;

        public RemovePoliclinic_2132(Policlinic_2132 clinic, HospitalCommand_2132 system)
        {
            _clinic = clinic;
            _system = system;
        }

        public void Execute()
        {
            _system.RemovePoliclinic(_clinic);
            Console.WriteLine("Required Policlinic removed: " + _clinic.Name);
        }

        public void Revoke()
        {
            _system.AddPoliclinic(_clinic);
            Console.WriteLine("Required Policlinic added: " + _clinic.Name);
        }
    }

}
