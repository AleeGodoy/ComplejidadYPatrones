using System;
using Practica04.Iterativos;
using Practica04.Recursivos;
using Practica04.Strategy;
using Practica04.Proxy;

namespace Practica04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
        }

        // EJERCICIO 1 - ITERATIVOS
        public static void ejercicio1()
        {
            int[] valores = { 10, 100, 1000 };

            foreach (int n in valores)
            {
                Console.WriteLine("================================");
                Console.WriteLine("EJERCICIO 1 - ITERATIVOS");
                Console.WriteLine("n = " + n);
                Console.WriteLine("================================");

                // Contar
                Contador.reiniciar();
                AlgoritmosIterativos.contar(n);
                long operaciones = Contador.getOperaciones();
                long formula = AlgoritmosIterativos.formulaContar(n);

                Console.WriteLine("Contar:");
                Console.WriteLine("Operaciones: " + operaciones);
                Console.WriteLine("Formula: " + formula);
                Console.WriteLine("Coinciden: " + (operaciones == formula));
                Console.WriteLine("Orden: O(n)");

                // Contar2
                Contador.reiniciar();
                AlgoritmosIterativos.contar2(n);
                operaciones = Contador.getOperaciones();
                formula = AlgoritmosIterativos.formulaContar2(n);

                Console.WriteLine("\nContar2:");
                Console.WriteLine("Operaciones: " + operaciones);
                Console.WriteLine("Formula: " + formula);
                Console.WriteLine("Coinciden: " + (operaciones == formula));
                Console.WriteLine("Orden: O(n²)");

                // ContarDependiente
                Contador.reiniciar();
                AlgoritmosIterativos.contarDependiente(n);
                operaciones = Contador.getOperaciones();
                formula = AlgoritmosIterativos.formulaDependiente(n);

                Console.WriteLine("\nContarDependiente:");
                Console.WriteLine("Operaciones: " + operaciones);
                Console.WriteLine("Formula: " + formula);
                Console.WriteLine("Coinciden: " + (operaciones == formula));
                Console.WriteLine("Orden: O(n²)");

                // TiempoWhile
                Contador.reiniciar();
                AlgoritmosIterativos.tiempoWhile(n);
                operaciones = Contador.getOperaciones();
                formula = AlgoritmosIterativos.formulaWhile(n);

                Console.WriteLine("\nTiempoWhile:");
                Console.WriteLine("Operaciones: " + operaciones);
                Console.WriteLine("Formula: " + formula);
                Console.WriteLine("Coinciden: " + (operaciones == formula));
                Console.WriteLine("Orden: O(log n)");

                Console.WriteLine();
            }
        }

        // EJERCICIO 2 - RECURSIVOS
        public static void ejercicio2()
        {
            int[] valores = { 5, 10, 20, 25 };

            foreach (int n in valores)
            {
                Console.WriteLine("================================");
                Console.WriteLine("EJERCICIO 2 - RECURSIVOS");
                Console.WriteLine("n = " + n);
                Console.WriteLine("================================");

                Contador.reiniciar();
                long resultado1 = AlgoritmosRecursivos.rec1(n);
                long operaciones1 = Contador.getOperaciones();
                long formula1 = AlgoritmosRecursivos.formulaRec1(n);

                Contador.reiniciar();
                long resultado2 = AlgoritmosRecursivos.rec2(n);
                long operaciones2 = Contador.getOperaciones();
                long formula2 = AlgoritmosRecursivos.formulaRec2(n);

                Console.WriteLine("Rec1:");
                Console.WriteLine("Resultado: " + resultado1);
                Console.WriteLine("Operaciones: " + operaciones1);
                Console.WriteLine("Formula: " + formula1);
                Console.WriteLine("Coinciden: " + (operaciones1 == formula1));

                Console.WriteLine("\nRec2:");
                Console.WriteLine("Resultado: " + resultado2);
                Console.WriteLine("Operaciones: " + operaciones2);
                Console.WriteLine("Formula: " + formula2);
                Console.WriteLine("Coinciden: " + (operaciones2 == formula2));

                Console.WriteLine("\n¿Devuelven el mismo resultado?: " +
                    (resultado1 == resultado2));

                Console.WriteLine("Ganancia: " +
                    (operaciones1 / operaciones2));

                Console.WriteLine();
            }
        }

        // EJERCICIO 3 - STRATEGY
        public static void ejercicio3()
        {
            int[] valores = { 1000, 10000, 100000, 1000000 };

            foreach (int n in valores)
            {
                ListaDeInscriptos lista = new ListaDeInscriptos(
                    new BusquedaLineal()
                );

                lista.cargar(n);

                Console.WriteLine("================================");
                Console.WriteLine("EJERCICIO 3 - STRATEGY");
                Console.WriteLine("Cantidad de alumnos: " + n);
                Console.WriteLine("================================");

                Contador.reiniciar();
                lista.setEstrategia(new BusquedaLineal());
                lista.buscar(n + 1);
                long operacionesLineal = Contador.getOperaciones();

                Contador.reiniciar();
                lista.setEstrategia(new BusquedaBinaria());
                lista.buscar(n + 1);
                long operacionesBinaria = Contador.getOperaciones();

                Console.WriteLine("Busqueda lineal: " + operacionesLineal);
                Console.WriteLine("Busqueda binaria: " + operacionesBinaria);
                Console.WriteLine("Ganancia: " +
                    (operacionesLineal / operacionesBinaria));

                Console.WriteLine();
            }
        }

        // EJERCICIO 4 - PROXY
        public static void ejercicio4()
        {
            int n = 10000;
            int cantidadConsultas = 1000;
            int legajoBuscado = 10000;

            Console.WriteLine("================================");
            Console.WriteLine("EJERCICIO 4 - PROXY");
            Console.WriteLine("================================");

            // Sin utilizar Proxy
            ServicioDeAlumnos servicio = new ServicioDeAlumnos(n);

            Contador.reiniciar();

            for (int i = 0; i < cantidadConsultas; i++)
            {
                servicio.buscarAlumno(legajoBuscado);
            }

            long operacionesSinCache = Contador.getOperaciones();

            // Utilizando Proxy
            ServicioDeAlumnos servicioReal = new ServicioDeAlumnos(n);
            ServicioDeAlumnosConCache proxy =
                new ServicioDeAlumnosConCache(servicioReal);

            Contador.reiniciar();

            for (int i = 0; i < cantidadConsultas; i++)
            {
                proxy.buscarAlumno(legajoBuscado);
            }

            long operacionesConCache = Contador.getOperaciones();

            Console.WriteLine("Consultas realizadas: " + cantidadConsultas);
            Console.WriteLine("Operaciones sin Proxy: " + operacionesSinCache);
            Console.WriteLine("Operaciones con Proxy: " + operacionesConCache);
            Console.WriteLine("Ganancia: " +
                (operacionesSinCache / operacionesConCache));
        }
    }
}