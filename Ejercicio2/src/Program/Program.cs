using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente= new Paciente("Steven Jhonson", "5555-555-555", "986782342", "24");
            Doctor doctor=new Doctor("Armand", "Cirujano");
            string appointmentResult = AppointmentService.CreateAppointment(paciente.NombrePaciente, paciente.Celular, paciente.Cedula, DateTime.Now, "Wall Street", doctor.DoctorName);
            Console.WriteLine(appointmentResult);
            Paciente paciente2= new Paciente("Steven Jhonson", "5555-555-555", "986782342", "24");
            Doctor doctor2=new Doctor("Armand", "Cirujano");
            string appointmentResult2 = AppointmentService.CreateAppointment(paciente.NombrePaciente, paciente.Celular, paciente.Cedula, DateTime.Now, "Wall Street", doctor.DoctorName);
            Console.WriteLine(appointmentResult2);

        }
    }
}
