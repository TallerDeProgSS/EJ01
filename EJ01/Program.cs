using ClassLibrary1;

namespace Ej01
{
    public class Program01
    {
        static void Main(string[] args)
        {
            CapaAplicacion capaAplicacion = new CapaAplicacion();
            CapaControlador capaControlador = new CapaControlador();
            CapaDominio capaDominio = new CapaDominio();    
            CapaVista capaVista = new CapaVista();  
            CapaPersistencia capaPersistencia = new CapaPersistencia();

            capaVista.Ejecutar(capaControlador, capaAplicacion, capaDominio, capaPersistencia);
            Console.ReadKey();
        }
    }

}