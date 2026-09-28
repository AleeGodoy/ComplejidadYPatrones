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
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Clase 2");

            /*Console.WriteLine("Ejercicio 2");

            Pila pila = new Pila();
            Cola cola = new Cola();
            Catalogo multiple = new Catalogo(pila, cola);
            llenarSuscriptores(pila);
            llenarSuscriptores(cola);
            informar(multiple);
            */

            /*
            Console.WriteLine("Ejercicio 7");
            Pila pila = new Pila();
            Cola cola = new Cola();
            Playlist conjunto = new Playlist();

            llenarSuscriptores(pila);
            llenarSuscriptores(cola);
            llenarSuscriptores(conjunto);

            Console.WriteLine("PILA:");
            imprimirElementos(pila);
            Console.WriteLine("COLA:");
            imprimirElementos(cola);
            Console.WriteLine("CONJUNTO:");
            imprimirElementos(conjunto);
            */

            /*
            Console.WriteLine("Ejercicio 9");

            Pila pila2 = new Pila();

            Console.WriteLine("ELEMENTOS DE PILA:");
            llenarSuscriptores(pila2);
            imprimirElementos(pila2);
            cambiarEstrategia(pila2, new EstrategiaPorNombre());
            Console.WriteLine("Estrategia por Nombre:");
            informar(pila2);
            cambiarEstrategia(pila2, new EstrategiaPorId());
            Console.WriteLine("Estrategia por Id:");
            informar(pila2);
            cambiarEstrategia(pila2, new EstrategiaPorMesesDeSuscripcion());
            Console.WriteLine("Estrategia por Meses de Suscripción:");
            informar(pila2);
            cambiarEstrategia(pila2, new EstrategiaPorHorasVistas());
            Console.WriteLine("Estrategia por Horas vistas:");
            informar(pila2);
            */

            /*
            Console.WriteLine("Ejercicio 2");
            Pila pila = new Pila();
            llenarFactory(pila, 3);
            informarFactory(pila, 3);
            */

            // Ejercicio 14
            /*
            Canal canal = new FabricaDeCanales().crearPorTeclado();
            Pila p = new Pila();
            llenarFactory(p, 2);
            Iterador ite = p.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                canal.agregarObservador((Observador)ite.actual());
                ite.siguiente();
            }
            temporadaDeContenido(canal);*/

            /*Comparable suscriptor = FabricaDeComparables.crearAleatorio(2);
            Mostrable decorado = (Suscriptor)suscriptor;

            decorado = new DecoradorAntiguedad(decorado);
            decorado = new DecoradorFanatico(decorado);
            decorado = new DecoradorEstadoCuenta(decorado);
            decorado = new DecoradorRecuadro(decorado);

            Console.WriteLine(decorado.mostrarInfo());*/

            Canal canal = new Canal("CTyPDS UNAJ");

            for (int i = 0; i < 10; i++)
            {
                Comparable suscriptor = FabricaDeComparables.crearAleatorio(2);

                canal.agregarObservador((Observador)suscriptor);
            }

            temporadaDeContenido(canal);

            foreach (Observador observador in canal.getObservadores())
            {
                Suscriptor suscriptor = (Suscriptor)observador;

                Mostrable decorado = suscriptor;

                decorado = new DecoradorAntiguedad(decorado);
                decorado = new DecoradorFanatico(decorado);
                decorado = new DecoradorEstadoCuenta(decorado);
                decorado = new DecoradorRecuadro(decorado);

                Console.WriteLine(decorado.mostrarInfo());
            }
        }

        public static void llenarSuscriptores(Coleccionable coleccionable)
        {
            string[] nombres =
            {
                "Ana",
                "Juan",
                "Pedro",
                "Lucía",
                "Mauro",
                "Carla",
                "Sofía",
                "Diego",
                "Valentina",
                "Martín"
            };

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int id = random.Next(1, 1001);
                int meses = random.Next(1, 61);
                int horas = random.Next(1, 2001);

                Suscriptor suscriptor =
                    new Suscriptor(nombre, id, meses, horas);

                suscriptor.setEstrategia(new EstrategiaPorNombre());

                coleccionable.agregar(suscriptor);
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Cantidad de elementos: {coleccionable.cuantos()}");
            Console.WriteLine($"Mínimo: {coleccionable.minimo()}");
            Console.WriteLine($"Máximo: {coleccionable.maximo()}");

            /*Console.Write("Ingrese un ID para buscar: ");
            int id = int.Parse(Console.ReadLine());

            Comparable c = new Suscriptor("", id, 0, 0);

            if (coleccionable.contiene(c))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }

            Console.WriteLine("------------------------------");*/
        }

        public static void imprimirElementos(Coleccionable col)
        {
            Iterador ite = col.crearIterador();

            ite.primero();
            while (!ite.fin())
            {
                Console.WriteLine(ite.actual());
                ite.siguiente();
            }

            Console.WriteLine("Ya no quedan elementos por recorrer");
        }

        public static void cambiarEstrategia(Coleccionable c, EstrategiaDeComparacion e)
        {
            Iterador ite = c.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                ((Suscriptor)ite.actual()).setEstrategia(e);
                ite.siguiente();
            }
        }

        public static void llenarFactory(Coleccionable c, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                c.agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }

        public static void informarFactory(Coleccionable c, int opcion)
        {
            Console.WriteLine("Cuantos: " + c.cuantos());
            Console.WriteLine("Mínimo: " + c.minimo());
            Console.WriteLine("Máximo: " + c.maximo());

            Comparable comparable =
                FabricaDeComparables.crearPorTeclado(opcion);

            if (c.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
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
    }
}