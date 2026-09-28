using System.Collections.Generic;
using Practica02.Iterator;

namespace Practica02
{
    public class Playlist : Coleccionable
    {
        private List<Comparable> elementos = new List<Comparable>();

        public void agregar(Comparable comparable)
        {
            if (!pertenece(comparable))
            {
                elementos.Add(comparable);
            }
        }

        public bool pertenece(Comparable comparable)
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
            return pertenece(comparable);
        }

        public Iterador crearIterador()
        {
            return new IteradorDePlaylist(elementos);
        }
    }
}