using System;

namespace Practica02.Decorator
{
    public class DecoradorRecuadro : DecoradorSuscriptor
    {
        public DecoradorRecuadro(Mostrable componente)
            : base(componente)
        {
        }

        public override string mostrarInfo()
        {
            string info = componente.mostrarInfo();

            string linea =
                new string('*', info.Length + 4);

            return linea + Environment.NewLine +
                   $"* {info} *" + Environment.NewLine +
                   linea;
        }
    }
}