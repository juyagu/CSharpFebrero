using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class AulaDAO
    {
        public static List<aulas> ObtenerAulas()
        {
            List<aulas> aulas = new List<aulas>();
            ABM_AlumnosEntities contexto = new ABM_AlumnosEntities();

            aulas = contexto.aulas.ToList();

            return aulas;
        } 
    }
}
