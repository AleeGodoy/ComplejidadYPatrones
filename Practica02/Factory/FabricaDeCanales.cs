using Practica02;

namespace Practica02.Factory
{
    public class FabricaDeCanales
    {
        public static Canal crearCanal(string nombre)
        {
            return new Canal(nombre);
        }
    }
}