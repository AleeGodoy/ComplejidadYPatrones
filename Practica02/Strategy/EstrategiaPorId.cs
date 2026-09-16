using Practica02;

namespace Practica02.Strategy
{
    public class EstrategiaPorId : EstrategiaDeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getId() == b.getId();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getId() < b.getId();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getId() > b.getId();
        }
    }
}