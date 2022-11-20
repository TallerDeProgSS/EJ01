using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AplicattionException : Exception
    {
        public DateTime fechaHora;

        public AplicattionException()
        {
           fechaHora = DateTime.Now;
        }
    }

    public class ErrorPuntualException : AplicattionException
    {
        public string mensaje;

        public ErrorPuntualException()
        {
            this.mensaje = "Error Putual (#201)";
        }
    }

    public class CapaAplicacionException : AplicattionException
    {
        public string mensaje;

        public CapaAplicacionException()        //Referenciando a la exception directamente
        {
            this.mensaje = "Error General (#301)";
        }

        public CapaAplicacionException(ErrorPuntualException origen)         //Referenciando a la exception pero con un origen. (el cual es el error puntual)
        {
            this.mensaje = "Error General (#301)";
            Console.WriteLine(origen.mensaje);
            Console.WriteLine(origen.fechaHora);
        }
    }
}
