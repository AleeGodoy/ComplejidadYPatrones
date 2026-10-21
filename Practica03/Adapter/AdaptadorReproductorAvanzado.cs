using System;
using System.IO;

namespace Practica03.Adapter
{
    public class AdaptadorReproductorAvanzado : IReproductor
    {
        private ReproductorAvanzadoExterno reproductorExterno;

        public AdaptadorReproductorAvanzado(ReproductorAvanzadoExterno reproductorExterno)
        {
            this.reproductorExterno = reproductorExterno;
        }

        public void Reproducir(string archivo)
        {
            string extension = Path.GetExtension(archivo).ToLower();

            if (extension == ".avi")
            {
                reproductorExterno.reproducirArchivoAvi(archivo);
            }
            else if (extension == ".mp4")
            {
                reproductorExterno.reproducirArchivoMp4(archivo);
            }
            else
            {
                Console.WriteLine($"Formato no soportado: {archivo}");
            }
        }
    }
}