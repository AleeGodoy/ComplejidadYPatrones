using System.Collections.Generic;
using Practica04;

namespace Practica04.Strategy
{
    public class BusquedaLineal : EstrategiaDeBusqueda
    {
        public Alumno Buscar(List<Alumno> alumnos, int legajo)
        {
            foreach (Alumno alumno in alumnos)
            {
                Contador.sumar();

                if (alumno.getLegajo() == legajo)
                {
                    return alumno;
                }
            }

            return null;
        }
    }
}