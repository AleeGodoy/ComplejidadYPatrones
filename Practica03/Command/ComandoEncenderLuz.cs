using System;

namespace Practica03.Command
{
    public class ComandoEncenderLuz : IComando
    {
        private Luz luz;

        public ComandoEncenderLuz(Luz luz)
        {
            this.luz = luz;
        }

        public void Ejecutar()
        {
            luz.Encender();
        }

        public void Deshacer()
        {
            luz.Apagar();
        }
    }
}