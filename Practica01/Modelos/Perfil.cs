using Practica01.Interfaces;

namespace Practica01.Modelos
{
    public abstract class Perfil : Comparable
    {
        private string nombre;
        private int id;

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

        public virtual bool sosIgual(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;

            return id == perfil.getId();
        }

        public virtual bool sosMenor(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;

            return id < perfil.getId();
        }

        public virtual bool sosMayor(Comparable comparable)
        {
            Perfil perfil = (Perfil)comparable;

            return id > perfil.getId();
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, ID: {id}";
        }
    }
}