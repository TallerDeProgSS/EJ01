using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CapaAplicacion
    {
        public void Ejecutar(CapaDominio dominio, CapaPersistencia persistencia)
        {
            try
            {
                dominio.Ejecutar(persistencia);
            }
            catch (ErrorPuntualException error)
            {
                //Console.ReadKey();                ///// desmarcar en casa de querer comprobar que el tiempo de las excepciones son distintas /////
                throw new CapaAplicacionException(error);
            }
        }
    }
}
