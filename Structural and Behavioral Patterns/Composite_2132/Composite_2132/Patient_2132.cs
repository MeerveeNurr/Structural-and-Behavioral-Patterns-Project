using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite_2132
{
    internal class Patient_2132 : IComposite_2132
    {
        private string _name;
        private string _diagnosis;

        public Patient_2132(string name, string diagnosis)
        {
            _name = name;
            _diagnosis = diagnosis;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient: {_name}, Diagnosis: {_diagnosis}");
        }
    }
}
