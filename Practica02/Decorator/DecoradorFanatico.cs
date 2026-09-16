using Practica02;

namespace Practica02.Decorator
{
    public class DecoradorFanatico : DecoradorSuscriptor
    {
        public DecoradorFanatico(Mostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            Suscriptor s = getSuscriptor();

            string nivel;

            if (s.getHorasVistas() < 10)
            {
                nivel = "Bronce";
            }
            else if (s.getHorasVistas() < 50)
            {
                nivel = "Plata";
            }
            else
            {
                nivel = "Oro";
            }

            return $"[{nivel}] {componente.mostrarInfo()}";
        }
    }
}