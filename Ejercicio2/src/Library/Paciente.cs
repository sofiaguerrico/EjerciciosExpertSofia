using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string NombrePaciente { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Edad { get; set; }
        public Paciente(string nom, string ci, string cel, string edad)
        {
            this.NombrePaciente=nom;
            this.Cedula=ci;
            this.Celular=cel;
            this.Edad=edad;
        }
    }
}