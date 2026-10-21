using System;
using System.Collections.Generic;

namespace Practica03.Composite
{
    public class Carpeta : IElementoSistemaArchivos
    {
        private string nombre;
        private List<IElementoSistemaArchivos> elementos;

        public Carpeta(string nombre)
        {
            this.nombre = nombre;
            elementos = new List<IElementoSistemaArchivos>();
        }

        public void Agregar(IElementoSistemaArchivos elemento)
        {
            elementos.Add(elemento);
        }

        public int ObtenerTamano()
        {
            int tamanoTotal = 0;

            foreach (IElementoSistemaArchivos elemento in elementos)
            {
                tamanoTotal += elemento.ObtenerTamano();
            }

            return tamanoTotal;
        }

        public void Mostrar(int nivelDeIndentacion)
        {
            Console.WriteLine(
                new string(' ', nivelDeIndentacion * 2) + nombre);

            foreach (IElementoSistemaArchivos elemento in elementos)
            {
                elemento.Mostrar(nivelDeIndentacion + 1);
            }
        }
    }
}