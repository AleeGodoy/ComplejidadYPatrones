using System;

namespace Practica03.Adapter
{
    public class ReproductorMp3 : IReproductor
    {
        public void Reproducir(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo MP3: {archivo}");
        }
    }
}