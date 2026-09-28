using Practica02.Iterator;

namespace Practica02
{
    public interface Coleccionable : Iterable
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        void agregar(Comparable comparable);

        bool contiene(Comparable comparable);
    }
}