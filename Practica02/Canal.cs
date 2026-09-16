using System;
using System.Collections.Generic;
using Practica02.Observer;

namespace Practica02
{
    public class Canal : Observado
    {
        private string nombre;
        private bool enVivo;

        private List<Observador> observadores =
            new List<Observador>();

        public Canal(string nombre)
        {
            this.nombre = nombre;
        }

        public void publicarContenido()
        {
            Console.WriteLine($"{nombre} publicó contenido nuevo");

            enVivo = false;

            notificar();
        }

        public void iniciarEnVivo()
        {
            Console.WriteLine($"{nombre} está en vivo");

            enVivo = true;

            notificar();
        }

        public bool estaEnVivo()
        {
            return enVivo;
        }

        public void agregarObservador(Observador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(Observador o)
        {
            observadores.Remove(o);
        }

        public List<Observador> getObservadores()
        {
            return observadores;
        }

        public void notificar()
        {
            foreach (Observador obs in observadores)
            {
                obs.actualizar(this);
            }
        }
    }
}