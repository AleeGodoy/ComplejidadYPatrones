using System.Collections.Generic;
using Practica04;

namespace Practica04.Proxy
{
    public class ServicioDeAlumnos : IServicioDeAlumnos
    {
        private List<Alumno> alumnos;

        public ServicioDeAlumnos(int n)
        {
            alumnos = new List<Alumno>();

            for (int i = 1; i <= n; i++)
            {
                alumnos.Add(new Alumno(i, "Alumno " + i));
            }
        }

        public Alumno buscarAlumno(int legajo)
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