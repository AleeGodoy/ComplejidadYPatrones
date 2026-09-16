namespace Practica02
{
    public abstract class Perfil : Comparable
    {
        protected string nombre;
        protected int id;

        public Perfil(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getId()
        {
            return id;
        }

        public abstract bool sosIgual(Comparable comparable);

        public abstract bool sosMenor(Comparable comparable);

        public abstract bool sosMayor(Comparable comparable);
    }
}