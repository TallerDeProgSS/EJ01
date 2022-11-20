namespace ClassLibrary1
{
    public class CapaVista
    {
        public void Ejecutar(CapaControlador controlador, CapaAplicacion aplicacion, CapaDominio dominio, CapaPersistencia persistencia)
        {
            try
            {
                controlador.Ejecutar(aplicacion, dominio, persistencia);
            }
            catch(CapaAplicacionException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.mensaje);
                Console.WriteLine(ex.fechaHora);
                Console.ReadLine();
            }
        }
    }
}