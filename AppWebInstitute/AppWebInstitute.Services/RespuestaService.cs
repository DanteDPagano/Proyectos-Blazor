using System;
using System.Collections.Generic;
namespace AppWebInstitute.Services
{
    //El nombre generalmente se pone en ingles y es para que este escrito en un idioma
    //un poco mas universal.
    //ResponseServices
    public class RespuestaService<T>
    {
        public T? Objeto { get; set; }
        public string? Error { get; set; }
        public int Status { get; set; }
        public bool Successful { get; set; } // Exitoso

        public RespuestaService()
        {
            Status = 200; //Aceptar OK.
        }

        public void AddBadResquest(string message)
        {
            Status = 400; //Argumento no válido o solicitud incorrecta.
            Error = message;
        }

        public void AddInternalServerError(string message)
        {
            Status = 500; //Error del servidor interno
            Error = message;
        }
    }

}

