using System.Collections.Generic;
using Practica04;

namespace Practica04.Strategy
{
    public class BusquedaBinaria : EstrategiaDeBusqueda
    {
        public Alumno Buscar(List<Alumno> alumnos, int legajo)
        {
            int inicio = 0;
            int fin = alumnos.Count - 1;

            while (inicio <= fin)
            {
                Contador.sumar();

                int medio = (inicio + fin) / 2;

                if (alumnos[medio].getLegajo() == legajo)
                {
                    return alumnos[medio];
                }
                else if (alumnos[medio].getLegajo() < legajo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return null;
        }
    }
}