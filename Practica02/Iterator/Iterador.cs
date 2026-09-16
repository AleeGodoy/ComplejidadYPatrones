using Practica02;

namespace Practica02.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}