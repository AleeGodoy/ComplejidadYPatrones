using Practica01.Interfaces;

namespace Practica01.Modelos
{
    public class Visualizacion : Comparable
    {
        private int cantidad;

        public Visualizacion(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public bool sosIgual(Comparable comparable)
        {
            Visualizacion visualizacion = (Visualizacion)comparable;

            return cantidad == visualizacion.getCantidad();
        }

        public bool sosMenor(Comparable comparable)
        {
            Visualizacion visualizacion = (Visualizacion)comparable;

            return cantidad < visualizacion.getCantidad();
        }

        public bool sosMayor(Comparable comparable)
        {
            Visualizacion visualizacion = (Visualizacion)comparable;

            return cantidad > visualizacion.getCantidad();
        }

        public override string ToString()
        {
            return $"Visualización: {cantidad}";
        }
    }
}