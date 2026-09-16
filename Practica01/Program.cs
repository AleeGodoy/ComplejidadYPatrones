using System;
using Practica01.Colecciones;
using Practica01.Funciones;

namespace Practica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRÁCTICA 1 ===");
            Console.WriteLine();

            Pila pila = new Pila();
            Cola cola = new Cola();

            Console.WriteLine("Llenando la pila...");
            FuncionesAct1.llenar(pila);

            Console.WriteLine("Llenando la cola...");
            FuncionesAct1.llenar(cola);

            Console.WriteLine();
            Console.WriteLine("INFORMACIÓN DE LA PILA");
            FuncionesAct1.informar(pila);

            Console.WriteLine();
            Console.WriteLine("INFORMACIÓN DE LA COLA");
            FuncionesAct1.informar(cola);

            Console.WriteLine();
            Console.WriteLine("Creando catálogo...");

            Catalogo catalogo =
                new Catalogo(pila, cola);

            Console.WriteLine();
            Console.WriteLine("INFORMACIÓN DEL CATÁLOGO");
            FuncionesAct1.informar(catalogo);

            Console.WriteLine();
            Console.WriteLine("Presione ENTER para finalizar.");
            Console.ReadLine();
        }
    }
}