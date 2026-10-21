using System;

namespace Practica03.Adapter
{
    public class ReproductorAvanzadoExterno
    {
        public void reproducirArchivoAvi(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo AVI: {archivo}");
        }

        public void reproducirArchivoMp4(string archivo)
        {
            Console.WriteLine($"Reproduciendo archivo MP4: {archivo}");
        }
    }
}