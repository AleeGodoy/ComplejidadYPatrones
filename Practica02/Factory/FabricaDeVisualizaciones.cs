using System;
using Practica02;

namespace Practica02.Factory
{
    public class FabricaDeVisualizaciones : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Visualizacion(
                generador.numeroAleatorio(40)
            );
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Ingrese cantidad de visualizaciones:    ");

            int cantidad = lector.numeroPorTeclado();

            return new Visualizacion(cantidad);
        }
    }
}