using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Facade_2132
{
    internal class Facade_2132
    {
            private DoctorFacade_2132 doctorManager = new DoctorFacade_2132();
            private PatientFacade_2132 patientManager = new PatientFacade_2132();
            private AppointmentFacade_2132 appointmentManager = new AppointmentFacade_2132();
            private PoliclinicFacade_2132 polyclinicManager = new PoliclinicFacade_2132();

            public void AddDoctor(Doctor_2132 doctor)
            {
                doctorManager.AddDoctor(doctor);
            }

            public void RemoveDoctor(Doctor_2132 doctor)
            {
                doctorManager.RemoveDoctor(doctor);
            }

            public void AddPatient(Patient_2132 patient)
            {
                patientManager.AddPatient(patient);
            }

            public void RemovePatient(Patient_2132 patient)
            {
                patientManager.RemovePatient(patient);
            }

            public void AddAppointment(Appointment_2132 appointment)
            {
                appointmentManager.AddAppointment(appointment);
            }

            public void RemoveAppointment(Appointment_2132 appointment)
            {
                appointmentManager.RemoveAppointment(appointment);
            }

            public void AddPolyclinic(Policlinic_2132 polyclinic)
            {
                polyclinicManager.AddPolyclinic(polyclinic);
            }

            public void RemovePolyclinic(Policlinic_2132 polyclinic)
            {
                polyclinicManager.RemovePolyclinic(polyclinic);
            }
        }

    }
