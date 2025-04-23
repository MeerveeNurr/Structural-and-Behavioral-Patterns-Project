using System.Numerics;

namespace Command_2132
{
    class Program
    {
        static void Main(string[] args)
        {
            var hospitalSystem = new HospitalCommand_2132();
            var invoker = new HospitalInvoker_2132();

            var doctor = new Doctor_2132("Dr. Merve", "Cardiology");
            var patient = new Patient_2132("Ahmet Aslan", 30);
            var appointment = new Appointment_2132("Cardiology Department", DateTime.Now, doctor, patient);
            var clinic = new Policlinic_2132("Cardiology Clinic", "Hospital Araştırma");
            var doctor2 = new Doctor_2132("Dr. Sefa", "Dermatology");
            var patient2 = new Patient_2132("Mehmet Kaplan", 46);
            var appointment2 = new Appointment_2132("Dermatology Department", DateTime.Now, doctor, patient);
            var clinic2 = new Policlinic_2132("Dermatology Clinic", "Hospital Ünivercity");

            var addDoctorCommand = new AddDoctor_2132(doctor, hospitalSystem);
            var removeDoctorCommand = new RemoveDoctor_2132(doctor, hospitalSystem);
            var removePoliclinicCommand = new RemovePoliclinic_2132(clinic, hospitalSystem);
            var addPatientCommand = new AddPatient_2132(patient, hospitalSystem);
            var removePatientCommand = new RemovePatient_2132(patient, hospitalSystem);
            var createAppointmentCommand = new CreateAppointment_2132(appointment, hospitalSystem);
            var cancelAppointmentCommand = new CancelAppointment_2132(appointment, hospitalSystem);
            var addClinicCommand = new AddPoliclinic_2132(clinic, hospitalSystem);
            var addDoctorCommand2 = new AddDoctor_2132(doctor2, hospitalSystem);
            var removeDoctorCommand2 = new RemoveDoctor_2132(doctor2, hospitalSystem);
            var removePoliclinicCommand2 = new RemovePoliclinic_2132(clinic2, hospitalSystem);
            var addPatientCommand2 = new AddPatient_2132(patient2, hospitalSystem);
            var removePatientCommand2 = new RemovePatient_2132(patient2, hospitalSystem);
            var createAppointmentCommand2 = new CreateAppointment_2132(appointment2, hospitalSystem);
            var cancelAppointmentCommand2 = new CancelAppointment_2132(appointment2, hospitalSystem);
            var addClinicCommand2 = new AddPoliclinic_2132(clinic2, hospitalSystem);

            invoker.ExecuteCommand(addDoctorCommand);
            invoker.ExecuteCommand(addPatientCommand);
            invoker.ExecuteCommand(addClinicCommand);

            invoker.ExecuteCommand(addDoctorCommand2);
            invoker.ExecuteCommand(addPatientCommand2);
            invoker.ExecuteCommand(addClinicCommand2);

            invoker.RevokeCommand(); 
            invoker.ExecuteCommand(removePatientCommand);
            invoker.ExecuteCommand(removeDoctorCommand);
            invoker.ExecuteCommand(removePoliclinicCommand);
            invoker.ExecuteCommand(createAppointmentCommand);
            invoker.ExecuteCommand(cancelAppointmentCommand);

            invoker.ExecuteCommand(removePatientCommand2);
            invoker.ExecuteCommand(removeDoctorCommand2);
            invoker.ExecuteCommand(removePoliclinicCommand2);
            invoker.ExecuteCommand(createAppointmentCommand2);
            invoker.ExecuteCommand(cancelAppointmentCommand2);
        }
    }
}