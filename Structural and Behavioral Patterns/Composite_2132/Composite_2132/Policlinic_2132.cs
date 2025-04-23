using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_2132
{
    internal class Policlinic_2132 : IComposite_2132
    {
        private string _name;

        public Policlinic_2132(string name)
        {
            _name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Policlinic: {_name}");
        }
    }
}
