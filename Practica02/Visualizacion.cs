namespace Practica02
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
            Visualizacion otra = (Visualizacion)comparable;
            return this.cantidad == otra.cantidad;
        }

        public bool sosMenor(Comparable comparable)
        {
            Visualizacion otra = (Visualizacion)comparable;
            return this.cantidad < otra.cantidad;
        }

        public bool sosMayor(Comparable comparable)
        {
            Visualizacion otra = (Visualizacion)comparable;
            return this.cantidad > otra.cantidad;
        }

        public override string ToString()
        {
            return $"Visualizacion: {cantidad}";
        }
    }
}