using System.Collections.Generic;
using Practica04;

namespace Practica04.Strategy
{
    public class ListaDeInscriptos
    {
        private List<Alumno> alumnos;
        private EstrategiaDeBusqueda estrategia;

        public ListaDeInscriptos(EstrategiaDeBusqueda estrategia)
        {
            alumnos = new List<Alumno>();
            this.estrategia = estrategia;
        }

        public void cargar(int n)
        {
            alumnos.Clear();

            for (int i = 1; i <= n; i++)
            {
                alumnos.Add(new Alumno(i, "Alumno " + i));
            }
        }

        public void setEstrategia(EstrategiaDeBusqueda estrategia)
        {
            this.estrategia = estrategia;
        }

        public Alumno buscar(int legajo)
        {
            return estrategia.Buscar(alumnos, legajo);
        }
    }
}