using System;
using System.Collections.Generic;
using Practica01.Interfaces;

namespace Practica01.Colecciones
{
    public class Pila : Coleccionable
    {
        private List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
        }

        public void apilar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        public Comparable desapilar()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            int ultimaPosicion = elementos.Count - 1;
            Comparable elemento = elementos[ultimaPosicion];

            elementos.RemoveAt(ultimaPosicion);

            return elemento;
        }

        public Comparable tope()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }

            return elementos[elementos.Count - 1];
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("La pila está vacía.");
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
                throw new InvalidOperationException("La pila está vacía.");
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
            apilar(comparable);
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