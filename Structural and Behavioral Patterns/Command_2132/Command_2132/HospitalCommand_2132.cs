using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Command_2132
{
    public class HospitalCommand_2132 // Alıcı Sınıfı
    {
            private List<Doctor_2132> _doctors = new List<Doctor_2132>();
            private List<Patient_2132> _patients = new List<Patient_2132>();
            private List<Appointment_2132> _appointments = new List<Appointment_2132>();
            private List<Policlinic_2132> _clinics = new List<Policlinic_2132>();

            public void AddDoctor(Doctor_2132 doctor)
            {
                _doctors.Add(doctor);
            }

            public void RemoveDoctor(Doctor_2132 doctor)
            {
                _doctors.Remove(doctor);
            }

            public void AddPatient(Patient_2132 patient)
            {
                _patients.Add(patient);
            }

            public void RemovePatient(Patient_2132 patient)
            {
                _patients.Remove(patient);
            }

            public void AddPoliclinic(Policlinic_2132 clinic)
            {
                _clinics.Add(clinic);
            }

            public void RemovePoliclinic(Policlinic_2132 clinic)
            {
                _clinics.Remove(clinic);
            }

            public void CreateAppointment(Appointment_2132 appointment)
            {
                _appointments.Add(appointment);
            }

            public void CancelAppointment(Appointment_2132 appointment)
            {
                _appointments.Remove(appointment);
            }
        }

    }
