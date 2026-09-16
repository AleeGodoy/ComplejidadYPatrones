using System.Collections.Generic;
using Practica02;

namespace Practica02.Iterator
{
    public class IteradorDePila : Iterador
    {
        private List<Comparable> elementos;
        private int posicion;

        public IteradorDePila(List<Comparable> elementos)
        {
            this.elementos = elementos;
            primero();
        }

        public void primero()
        {
            posicion = 0;
        }

        public void siguiente()
        {
            posicion++;
        }

        public bool fin()
        {
            return posicion >= elementos.Count;
        }

        public Comparable actual()
        {
            return elementos[posicion];
        }
    }
}