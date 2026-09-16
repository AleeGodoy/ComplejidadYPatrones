using Practica02;

namespace Practica02.Strategy
{
    public class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool SosIgual(Suscriptor a, Suscriptor b)
        {
            return a.getNombre() == b.getNombre();
        }

        public bool SosMenor(Suscriptor a, Suscriptor b)
        {
            return string.Compare(a.getNombre(), b.getNombre()) < 0;
        }

        public bool SosMayor(Suscriptor a, Suscriptor b)
        {
            return string.Compare(a.getNombre(), b.getNombre()) > 0;
        }
    }
}