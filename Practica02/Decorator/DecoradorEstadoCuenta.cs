using Practica02;

namespace Practica02.Decorator
{
    public class DecoradorEstadoCuenta : DecoradorSuscriptor
    {
        public DecoradorEstadoCuenta(Mostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            Suscriptor s = getSuscriptor();

            string estado =
                s.getHorasVistas() > 0
                    ? "Cuenta Activa"
                    : "Cuenta Inactiva";

            string info = componente.mostrarInfo();

            int posicion = info.IndexOf(" - ");

            if (posicion >= 0)
            {
                return info.Substring(0, posicion)
                       + $" ({estado})"
                       + info.Substring(posicion);
            }

            return info;
        }
    }
}