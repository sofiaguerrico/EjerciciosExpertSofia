using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string DoctorName { get; set; }
        public string DoctorEspecialidad { get; set; }
        public Doctor(string doctorName, string doctorEspecialidad)
        {
            this.DoctorName = doctorName;
            this.DoctorEspecialidad=doctorEspecialidad;    
        }
    }
}
