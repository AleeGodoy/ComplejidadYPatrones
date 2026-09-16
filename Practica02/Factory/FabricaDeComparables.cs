using Practica02;

namespace Practica02.Factory
{
    public abstract class FabricaDeComparables
    {
        public const int VISUALIZACION = 1;
        public const int SUSCRIPTOR = 2;

        protected GeneradorDeDatosAleatorios generador =
            new GeneradorDeDatosAleatorios();

        protected LectorDeDatos lector =
            new LectorDeDatos();

        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = obtenerFabrica(opcion);

            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = obtenerFabrica(opcion);

            return fabrica.crearPorTeclado();
        }

        private static FabricaDeComparables obtenerFabrica(int opcion)
        {
            if (opcion == VISUALIZACION)
            {
                return new FabricaDeVisualizaciones();
            }

            return new FabricaDeSuscriptores();
        }

        public abstract Comparable crearAleatorio();

        public abstract Comparable crearPorTeclado();
    }
}