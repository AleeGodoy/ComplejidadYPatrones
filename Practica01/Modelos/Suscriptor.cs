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
            return $"Suscriptor: {getNombre()}, ID: {getId()}, " +
                   $"Meses: {mesesDeSuscripcion}, Horas: {horasVistas}";
        }
    }
}