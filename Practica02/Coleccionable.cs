namespace Practica02
{
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable comparable);
        bool contiene(Comparable comparable);
    }
}