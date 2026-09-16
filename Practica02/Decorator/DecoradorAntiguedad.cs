using Practica02;

namespace Practica02.Decorator
{
    public class DecoradorAntiguedad : DecoradorSuscriptor
    {
        public DecoradorAntiguedad(Mostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            Suscriptor s = getSuscriptor();

            return $"{s.getNombre()} " +
                   $"(Suscriptor hace {s.getMesesDeSuscripcion()} meses) " +
                   $"- {s.getHorasVistas()} horas vistas";
        }
    }
}