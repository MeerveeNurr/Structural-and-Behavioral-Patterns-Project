using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class Patient_2132
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Diagnosis { get; set; }

        public Patient_2132(int id, string name, string diagnosis)
        {
            Id = id;
            Name = name;
            Diagnosis = diagnosis;
        }
    }
}
