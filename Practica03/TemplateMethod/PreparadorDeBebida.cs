using System;

namespace Practica03.TemplateMethod
{
    public abstract class PreparadorDeBebida
    {
        public void PrepararBebida()
        {
            HervirAgua();
            AgregarBaseDeSaborizante();
            VerterEnTaza();
            AgregarCondimentos();
        }

        private void HervirAgua()
        {
            Console.WriteLine("Hirviendo agua.");
        }

        public abstract void AgregarBaseDeSaborizante();

        private void VerterEnTaza()
        {
            Console.WriteLine("Vertiendo en la taza.");
        }

        public virtual void AgregarCondimentos()
        {
            Console.WriteLine("Agregando condimentos");
        }
    }
}