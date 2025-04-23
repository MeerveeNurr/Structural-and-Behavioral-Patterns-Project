using System.Numerics;
namespace Composite_2132
{

    class Program
    {
        static void Main()
        {
            Composite_2132 hospitalSystem = new Composite_2132();

            Doctor_2132 doctor1 = new Doctor_2132("Dr. Nur", "Cardiology");
            Doctor_2132 doctor2 = new Doctor_2132("Dr. Fatma", "Neurology");
            Doctor_2132 doctor3 = new Doctor_2132("Dr. Ekin", "Dermatology");

            Patient_2132 patient1 = new Patient_2132("Ayşe Kaplan", "Thyroid");
            Patient_2132 patient2 = new Patient_2132("Emre Aydın", "Rosacea");
            Patient_2132 patient3 = new Patient_2132("Özgür Işık", "Hernia");


            Policlinic_2132 polyclinic1 = new Policlinic_2132("Internal medicine");
            Policlinic_2132 polyclinic2 = new Policlinic_2132("Dermatology");

            Appointment_2132 appointment1 = new Appointment_2132(DateTime.Now, doctor1, patient1);
            Appointment_2132 appointment2 = new Appointment_2132(DateTime.Now.AddHours(1), doctor2, patient2);


            hospitalSystem.Add(doctor1);
            hospitalSystem.Add(doctor2);
            hospitalSystem.Add(doctor3);
            hospitalSystem .Add(patient1);
            hospitalSystem.Add(patient2);
            hospitalSystem.Add(polyclinic1);
            hospitalSystem.Add(polyclinic2);
            hospitalSystem.Add(appointment1);
            hospitalSystem.Add(appointment2);


            hospitalSystem.DisplayInfo();
        }
    }
}