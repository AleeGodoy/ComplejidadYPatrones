using System;
using Practica02.Decorator;
using Practica02.Observer;
using Practica02.Strategy;

namespace Practica02
{
    public class Suscriptor : Perfil, Observador, Mostrable
    {
        private int mesesDeSuscripcion;
        private int horasVistas;
        private EstrategiaDeComparacion estrategia;

        public Suscriptor(
            string nombre,
            int id,
            int mesesDeSuscripcion,
            int horasVistas
        ) : base(nombre, id)
        {
            this.mesesDeSuscripcion = mesesDeSuscripcion;
            this.horasVistas = horasVistas;

            estrategia = new EstrategiaPorHorasVistas();
        }

        public int getMesesDeSuscripcion()
        {
            return mesesDeSuscripcion;
        }

        public int getHorasVistas()
        {
            return horasVistas;
        }

        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }

        public EstrategiaDeComparacion getEstrategia()
        {
            return estrategia;
        }

        public override string ToString()
        {
            return $"Suscriptor: {nombre} | ID: {id} | Meses: {mesesDeSuscripcion} | Horas: {horasVistas}";
        }

        public override bool sosIgual(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;
            return estrategia.SosIgual(this, otro);
        }

        public override bool sosMenor(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;
            return estrategia.SosMenor(this, otro);
        }

        public override bool sosMayor(Comparable comparable)
        {
            Suscriptor otro = (Suscriptor)comparable;
            return estrategia.SosMayor(this, otro);
        }

        public void verContenido()
        {
            Console.WriteLine("Viendo el nuevo contenido");
        }

        public void reaccionarANotificacion()
        {
            string[] reacciones =
            {
                "Abriendo la notificación",
                "Lo veo después",
                "Silenciando notificaciones"
            };

            Random random = new Random();

            Console.WriteLine(
                reacciones[random.Next(reacciones.Length)]
            );
        }

        public void actualizar(Observado o)
        {
            Canal canal = (Canal)o;

            if (canal.estaEnVivo())
            {
                reaccionarANotificacion();
            }
            else
            {
                verContenido();
            }
        }

        public string mostrarInfo()
        {
            return $"{nombre} - {horasVistas} horas vistas";
        }

        public Suscriptor getSuscriptor()
        {
            return this;
        }
    }
}