using Strategy_2132;
using System.Numerics;
namespace Strategy_2132
{
    class Program
    {
        public static void Main(string[] args)
        {
            Doctor_2132 doctor = new Doctor_2132("Dr. Ahmet");
            Doctor_2132 doctor2 = new Doctor_2132("Dr. Merve");
            Patient_2132 patient1 = new Patient_2132("Ali");
            Patient_2132 patient2 = new Patient_2132("Ayse");
            Patient_2132 patient3 = new Patient_2132("Sule");

            HospitalStrategy_2132 medicationTreatment = new MedicationTreatment();
            HospitalStrategy_2132 physiotherapy = new Physiotherapy();
            HospitalStrategy_2132 surgery = new Surgery();
            HospitalStrategy_2132 chemotherapy = new Chemotherapy();

            doctor.AssignTreatment(patient1, medicationTreatment);
            patient1.ApplyTreatment();

            doctor.AssignTreatment(patient2, physiotherapy);
            patient2.ApplyTreatment();

            doctor.AssignTreatment(patient3, chemotherapy);
            patient3.ApplyTreatment();

            Policlinik_2132 polyclinic = new Policlinik_2132("Internal Medicine");
            Appointment_2132 appointment1 = new Appointment_2132(patient1, doctor, DateTime.Now.AddDays(1));
            Appointment_2132 appointment2 = new Appointment_2132(patient2, doctor, DateTime.Now.AddDays(2));
            Appointment_2132 appointment3 = new Appointment_2132(patient3, doctor2, DateTime.Now.AddDays(3));

            Console.WriteLine($"{appointment1.Patient.Name} has an appointment at {polyclinic.Name} on {appointment1.Date.ToShortDateString()}.");
            Console.WriteLine($"{appointment2.Patient.Name} has an appointment at {polyclinic.Name} on {appointment2.Date.ToShortDateString()}.");
            Console.WriteLine($"{appointment3.Patient.Name} has an appointment at {polyclinic.Name} on {appointment3.Date.ToShortDateString()}.");
        }
    }
}