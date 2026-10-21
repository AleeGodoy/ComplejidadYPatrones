using System;

namespace Practica03.Command
{
    public class ComandoApagarLuz : IComando
    {
        private Luz luz;

        public ComandoApagarLuz(Luz luz)
        {
            this.luz = luz;
        }

        public void Ejecutar()
        {
            luz.Apagar();
        }

        public void Deshacer()
        {
            luz.Encender();
        }
    }
}