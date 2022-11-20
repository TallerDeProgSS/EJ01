using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CapaControlador
    {
        public void Ejecutar(CapaAplicacion aplicacion, CapaDominio dominio, CapaPersistencia persistencia)
        {
            aplicacion.Ejecutar(dominio, persistencia);
        }
    }
}
