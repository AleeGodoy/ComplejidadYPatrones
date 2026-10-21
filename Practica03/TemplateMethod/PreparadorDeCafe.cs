using System;

namespace Practica03.TemplateMethod
{
    public class PreparadorDeCafe : PreparadorDeBebida
    {
        public override void AgregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando café.");
        }
    }
}