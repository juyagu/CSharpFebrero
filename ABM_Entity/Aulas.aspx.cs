using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DAO;

namespace ABM_Entity
{
    public partial class Aulas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_aulas.DataSource = AulaDAO.ObtenerAulas();
            grid_aulas.DataBind();

            grid_alumnos.DataSource = AlumnoDAO.ObtenerAlumnos();
            grid_alumnos.DataBind();

            grid_alumnos_view.DataSource = AlumnoDAO.AlumnosVista();
            grid_alumnos_view.DataBind();
        }


    }
}