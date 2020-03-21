using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class AlumnoDAO
    {
        public static List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            using(ABM_AlumnosEntities db = new ABM_AlumnosEntities())
            {
                alumnos = (
                    from u in db.usuarios
                    join a in db.alumnos
                    on u.id_usuario equals a.id_usuario
                    where a.regular == 1
                    select new Alumno
                    {
                        Id_Alumno = a.id_alumno,
                        Nombre = u.nombre,
                        Apellido = u.apellido
                    }).ToList();
            }

            return alumnos;
        }

        public static List<VIEW_ALUMNOS> AlumnosVista()
        {
            List<VIEW_ALUMNOS> alumnos = new List<VIEW_ALUMNOS>();
            using(ABM_AlumnosEntities db = new ABM_AlumnosEntities())
            {
                alumnos = db.VIEW_ALUMNOS.OrderBy(o => o.apellido).ToList();
            }
            return alumnos;
        }
    }
}
