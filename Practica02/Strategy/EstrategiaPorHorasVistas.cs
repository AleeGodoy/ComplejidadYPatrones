using Practica02;

namespace Practica02.Strategy
{
    public class EstrategiaPorHorasVistas : EstrategiaDeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() == b.getHorasVistas();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() < b.getHorasVistas();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getHorasVistas() > b.getHorasVistas();
        }
    }
}