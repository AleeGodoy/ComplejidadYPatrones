using System.Collections.Generic;
using Practica04;

namespace Practica04.Proxy
{
    public class ServicioDeAlumnosConCache : IServicioDeAlumnos
    {
        private IServicioDeAlumnos servicioReal;
        private Dictionary<int, Alumno> cache;

        public ServicioDeAlumnosConCache(IServicioDeAlumnos servicioReal)
        {
            this.servicioReal = servicioReal;
            cache = new Dictionary<int, Alumno>();
        }

        public Alumno buscarAlumno(int legajo)
        {
            if (cache.ContainsKey(legajo))
            {
                return cache[legajo];
            }

            Alumno alumno = servicioReal.buscarAlumno(legajo);

            if (alumno != null)
            {
                cache.Add(legajo, alumno);
            }

            return alumno;
        }
    }
}