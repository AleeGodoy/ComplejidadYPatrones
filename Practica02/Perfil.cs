using Practica02;
using System;

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

        public virtual bool sosIgual(Comparable comparable)
        {
            Perfil otro = (Perfil)comparable;
            return this.id == otro.id;
        }

        public virtual bool sosMenor(Comparable comparable)
        {
            Perfil otro = (Perfil)comparable;
            return this.id < otro.id;
        }

        public virtual bool sosMayor(Comparable comparable)
        {
            Perfil otro = (Perfil)comparable;
            return this.id > otro.id;
        }

        public override string ToString()
        {
            return $"Perfil: {nombre} | ID: {id}";
        }
    }
}