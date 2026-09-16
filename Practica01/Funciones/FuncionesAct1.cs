using System;
using Practica01.Colecciones;
using Practica01.Interfaces;
using Practica01.Modelos;

namespace Practica01.Funciones
{
    public static class FuncionesAct1
    {
        private static Random random = new Random();

        public static void llenar(Coleccionable coleccionable)
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    int cantidad = random.Next(1, 1001);

                    coleccionable.agregar(
                        new Visualizacion(cantidad)
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al llenar: {ex.Message}");
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            try
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(
                    $"Cantidad de elementos: {coleccionable.cuantos()}"
                );

                Console.WriteLine(
                    $"Mínimo: {coleccionable.minimo()}"
                );

                Console.WriteLine(
                    $"Máximo: {coleccionable.maximo()}"
                );

                Console.Write("Ingrese una cantidad para buscar: ");
                int cantidad = int.Parse(Console.ReadLine());

                Comparable comparable =
                    new Visualizacion(cantidad);

                if (coleccionable.contiene(comparable))
                {
                    Console.WriteLine(
                        "El elemento leído está en la colección."
                    );
                }
                else
                {
                    Console.WriteLine(
                        "El elemento leído no está en la colección."
                    );
                }

                Console.WriteLine("----------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al informar: {ex.Message}");
            }
        }

        public static void llenarSuscriptores(
            Coleccionable coleccionable)
        {
            try
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
                    string nombre =
                        nombres[random.Next(nombres.Length)];

                    int id = random.Next(1, 1001);
                    int meses = random.Next(1, 61);
                    int horas = random.Next(1, 2001);

                    Suscriptor suscriptor =
                        new Suscriptor(
                            nombre,
                            id,
                            meses,
                            horas
                        );

                    coleccionable.agregar(suscriptor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error al llenar suscriptores: {ex.Message}"
                );
            }
        }
    }
}