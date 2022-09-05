using System;
using System.Text;
using System.Collections.Generic;
namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            List<string> cita = new List<string>();
            int contador=1;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
                cita.Add($"{contador}");
                cita.Add(name);
                cita.Add(id);
                cita.Add(phoneNumber);
                cita.Add($"{date}");
                cita.Add(appoinmentPlace);
                cita.Add(doctorName);
                contador+=1;
            }
            //El siguiente código es de prueba para comprobar que los valores fueron ingresados correctamente a la lista. 
            //En todo caso sería una clase distinta para imprimir la información de la cita
            /*
            for (int i = 0; i < cita.Count; i++)
            {
                Console.WriteLine(cita[i]);
                
            }*/
            return stringBuilder.ToString();
        }

    }
}