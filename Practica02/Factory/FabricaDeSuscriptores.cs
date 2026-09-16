using System;
using Practica02;

namespace Practica02.Factory
{
    public class FabricaDeSuscriptores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Suscriptor(
                generador.stringAleatorio(),
                generador.numeroAleatorio(100000000),
                generador.numeroAleatorio(99999),
                generador.numeroAleatorio(99999)
            );
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = lector.stringPorTeclado();

            Console.WriteLine("Ingrese ID: ");
            int id = lector.numeroPorTeclado();

            Console.WriteLine("Ingrese meses de suscripción: ");
            int meses = lector.numeroPorTeclado();

            Console.WriteLine("Ingrese horas vistas: ");
            int horas = lector.numeroPorTeclado();

            return new Suscriptor(
                nombre,
                id,
                meses,
                horas
            );
        }
    }
}