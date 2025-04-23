using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade_2132 hospitalSystem = new Facade_2132();

        
            Doctor_2132 doctor1 = new Doctor_2132(1, "Dr. Merve", "Cardiology");
            Doctor_2132 doctor2 = new Doctor_2132(2, "Dr. Sefa", "Neurology");

          
            Patient_2132 patient1 = new Patient_2132(1, "Ahmet Koç", "cancer");
            Patient_2132 patient2 = new Patient_2132(2, "Mehmet Aslan", "diabetes");

            
            Policlinic_2132 polyclinic1 = new Policlinic_2132(1, "Cardiology");
            Policlinic_2132 polyclinic2 = new Policlinic_2132(2, "Neurology");


            hospitalSystem.AddDoctor(doctor1);
            hospitalSystem.AddDoctor(doctor2);


            hospitalSystem.AddPatient(patient1);
            hospitalSystem.AddPatient(patient2);

          
            hospitalSystem.AddPolyclinic(polyclinic1);
            hospitalSystem.AddPolyclinic(polyclinic2);

           
            Appointment_2132 appointment1 = new Appointment_2132(1, DateTime.Now, doctor1, patient1);
            Appointment_2132 appointment2 = new Appointment_2132(2, DateTime.Now.AddHours(1), doctor2, patient2);

            hospitalSystem.AddAppointment(appointment1);
            hospitalSystem.AddAppointment(appointment2);

           
            hospitalSystem.RemoveDoctor(doctor1);
            hospitalSystem.RemovePatient(patient1);
            hospitalSystem.RemoveAppointment(appointment1);
            hospitalSystem.RemovePolyclinic(polyclinic1);
        }
    }
}
