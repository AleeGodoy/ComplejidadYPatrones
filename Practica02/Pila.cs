using System.Collections.Generic;
using Practica02.Iterator;

namespace Practica02
{
    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> elementos = new List<Comparable>();

        public void agregar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable minimo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMenor(minimo))
                {
                    minimo = elemento;
                }
            }

            return minimo;
        }

        public Comparable maximo()
        {
            Comparable maximo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMayor(maximo))
                {
                    maximo = elemento;
                }
            }

            return maximo;
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

        public Iterador crearIterador()
        {
            return new IteradorDePila(elementos);
        }
    }
}