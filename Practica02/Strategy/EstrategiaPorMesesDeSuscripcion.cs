using Practica02;

namespace Practica02.Strategy
{
    public class EstrategiaPorMesesDeSuscripcion : EstrategiaDeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() == b.getMesesDeSuscripcion();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() < b.getMesesDeSuscripcion();
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return a.getMesesDeSuscripcion() > b.getMesesDeSuscripcion();
        }
    }
}