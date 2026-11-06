using System.Collections.Generic;
using Practica04;

namespace Practica04.Strategy
{
    public interface EstrategiaDeBusqueda
    {
        Alumno Buscar(List<Alumno> alumnos, int legajo);
    }
}