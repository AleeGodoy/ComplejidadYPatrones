using Practica01.Interfaces;
using System;

namespace Practica01.Modelos
{
    public class Suscriptor : Perfil
    {
        private int mesesDeSuscripcion;
        private int horasVistas;

        public Suscriptor(
            string nombre,
            int id,
            int mesesDeSuscripcion,
            int horasVistas)
            : base(nombre, id)
        {
            this.mesesDeSuscripcion = mesesDeSuscripcion;
            this.horasVistas = horasVistas;
        }

        public int getMesesDeSuscripcion()
        {
            return mesesDeSuscripcion;
        }

        public int getHorasVistas()
        {
            return horasVistas;
        }

        public override string ToString()
        {
            return $"Suscriptor: {nombre} | ID: {id} | Meses: {mesesDeSuscripcion} | Horas: {horasVistas}";
        }

        // Ejercicio 14
        public override bool sosIgual(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;

            return this.horasVistas == otro.horasVistas;
        }

        public override bool sosMenor(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;

            return this.horasVistas < otro.horasVistas;
        }

        public override bool sosMayor(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;

            return this.horasVistas > otro.horasVistas;
        }
    }
}