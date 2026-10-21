using System;

namespace Practica03.TemplateMethod
{
    public class PreparadorDeTe : PreparadorDeBebida
    {
        public override void AgregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando té.");
        }

        public override void AgregarCondimentos()
        {
            Console.WriteLine("Agregando miel y limón.");
        }
    }
}