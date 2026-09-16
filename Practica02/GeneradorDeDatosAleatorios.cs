using System;

namespace Practica02
{
    public class GeneradorDeDatosAleatorios
    {
        private static Random random = new Random();

        public int numeroAleatorio(int max)
        {
            return random.Next(0, max + 1);
        }

        public string stringAleatorio(int cant = 5)
        {
            const string caracteres =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            string resultado = "";

            for (int i = 0; i < cant; i++)
            {
                resultado += caracteres[random.Next(caracteres.Length)];
            }

            return resultado;
        }
    }
}