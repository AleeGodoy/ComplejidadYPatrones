using System;
using Practica02;

namespace Practica02.Factory
{
    public class FabricaDeCanales
    {
        public Canal crearPorTeclado()
        {
            Console.WriteLine("Ingrese nombre del canal: ");

            string nombre = Console.ReadLine();

            return new Canal(nombre);
        }
    }
}