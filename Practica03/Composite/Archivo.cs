using System;

namespace Practica03.Composite
{
    public class Archivo : IElementoSistemaArchivos
    {
        private string nombre;
        private int tamano;

        public Archivo(string nombre, int tamano)
        {
            this.nombre = nombre;
            this.tamano = tamano;
        }

        public int ObtenerTamano()
        {
            return tamano;
        }

        public void Mostrar(int nivelDeIndentacion)
        {
            Console.WriteLine(
                new string(' ', nivelDeIndentacion * 2) + nombre);
        }
    }
}