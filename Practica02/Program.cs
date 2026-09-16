using Practica02.Decorator;
using Practica02.Factory;
using Practica02.Iterator;
using Practica02.Observer;
using Practica02.Strategy;
using System;

namespace Practica02
{
    public class Program
    {
        public static void llenarSuscriptores(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Suscriptor suscriptor =
                    (Suscriptor)FabricaDeComparables.crearAleatorio(
                        FabricaDeComparables.SUSCRIPTOR
                    );

                coleccionable.agregar(suscriptor);
            }
        }

        public static void imprimirElementos(Coleccionable coleccionable)
        {
            Iterable iterable = (Iterable)coleccionable;

            Iterador iterador = iterable.crearIterador();

            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());

                iterador.siguiente();
            }
        }

        public static void cambiarEstrategia(
            Coleccionable coleccionable,
            EstrategiaDeComparacion estrategia)
        {
            Iterable iterable = (Iterable)coleccionable;

            Iterador iterador = iterable.crearIterador();

            while (!iterador.fin())
            {
                Suscriptor suscriptor =
                    (Suscriptor)iterador.actual();

                suscriptor.setEstrategia(estrategia);

                iterador.siguiente();
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine(
                $"Cantidad: {coleccionable.cuantos()}"
            );

            Console.WriteLine(
                $"Minimo: {coleccionable.minimo()}"
            );

            Console.WriteLine(
                $"Maximo: {coleccionable.maximo()}"
            );
        }

        public static void llenarFactory(
            Coleccionable coleccionable,
            int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable =
                    FabricaDeComparables.crearAleatorio(opcion);

                coleccionable.agregar(comparable);
            }
        }

        public static void informarFactory(
            Coleccionable coleccionable,
            int opcion)
        {
            Console.WriteLine(
                $"Cantidad: {coleccionable.cuantos()}"
            );

            Console.WriteLine(
                $"Minimo: {coleccionable.minimo()}"
            );

            Console.WriteLine(
                $"Maximo: {coleccionable.maximo()}"
            );

            Comparable comparable =
                FabricaDeComparables.crearPorTeclado(opcion);

            if (coleccionable.contiene(comparable))
            {
                Console.WriteLine(
                    "El elemento leído está en la colección"
                );
            }
            else
            {
                Console.WriteLine(
                    "El elemento leído no está en la colección"
                );
            }
        }

        public static void temporadaDeContenido(Canal canal)
        {
            for (int i = 0; i < 5; i++)
            {
                canal.publicarContenido();
                canal.iniciarEnVivo();
            }
        }

        public static void Main(string[] args)
        {
            Canal canal =
                new Canal("CTyPDS UNAJ");

            for (int i = 0; i < 10; i++)
            {
                Suscriptor suscriptor =
                    (Suscriptor)
                    FabricaDeComparables.crearAleatorio(
                        FabricaDeComparables.SUSCRIPTOR
                    );

                canal.agregarObservador(suscriptor);
            }

            temporadaDeContenido(canal);

            foreach (Observador observador in canal.getObservadores())
            {
                Suscriptor suscriptor =
                    (Suscriptor)observador;

                Mostrable mostrable =
                    new DecoradorAntiguedad(suscriptor);

                mostrable =
                    new DecoradorFanatico(mostrable);

                mostrable =
                    new DecoradorEstadoCuenta(mostrable);

                mostrable =
                    new DecoradorRecuadro(mostrable);

                Console.WriteLine(
                    mostrable.mostrarInfo()
                );
            }
        }
    }
}