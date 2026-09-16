using Practica01.Modelos;

namespace Practica01.Interfaces
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