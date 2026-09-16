using System;
using System.Collections.Generic;
using Practica01.Interfaces;

namespace Practica01.Colecciones
{
    public class Cola : Coleccionable
    {
        private List<Comparable> elementos;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public void encolar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        public Comparable desencolar()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            Comparable elemento = elementos[0];

            elementos.RemoveAt(0);

            return elemento;
        }

        public Comparable primero()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return elementos[0];
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            Comparable minimo = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMenor(minimo))
                {
                    minimo = elementos[i];
                }
            }

            return minimo;
        }

        public Comparable maximo()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            Comparable maximo = elementos[0];

            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].sosMayor(maximo))
                {
                    maximo = elementos[i];
                }
            }

            return maximo;
        }

        public void agregar(Comparable comparable)
        {
            encolar(comparable);
        }

        public bool contiene(Comparable comparable)
        {
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }
    }
}