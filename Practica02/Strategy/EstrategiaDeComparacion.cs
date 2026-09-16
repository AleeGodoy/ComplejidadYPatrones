using Practica02;

namespace Practica02.Strategy
{
    public interface EstrategiaDeComparacion
    {
        bool SosIgual(Suscriptor a, Suscriptor b);
        bool SosMenor(Suscriptor a, Suscriptor b);
        bool SosMayor(Suscriptor a, Suscriptor b);
    }
}