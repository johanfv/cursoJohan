using EjemploOracle.vistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploOracle.vistas
{
    public class RespuestaService<T>
    {
        public RespuestaService()
        {
            Status = 200;
        }

        public T? Objeto { get; set; }
        public string? Error { get; set; }
        public int Status { get; set; }
        public bool Exito { get; set; }

        public void AgregarBadRequest(string mensaje)
        {
            Status = 400;
            Error = mensaje;
        }

        public void AgregarInternalServerError(string mensaje)
        {
            Status = 500;
            Error = mensaje;
        }

        //public static implicit operator List<T>(RespuestaService<List<Categorium>> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}