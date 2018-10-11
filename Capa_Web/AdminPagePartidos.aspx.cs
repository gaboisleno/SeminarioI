using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class AdminPagePartidos: System.Web.UI.Page {
        SqlInterfaz sq = new SqlInterfaz();
        List<Liga> ligas = new List<Liga>();
        List<Equipo> equipos = new List<Equipo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            //Cargar las ligas
            ligas = sq.TraerLigas();
            foreach (Liga l in ligas)
            {
                DDListLiga.Items.Add(l.getNombre());
            }

            //Cargar los equipos
            equipos = sq.TraerEquipos();
            foreach (Liga l in ligas)
            {
                DDListLocal.Items.Add(l.getNombre());
                DDListVisitante.Items.Add(l.getNombre());
            }

        }

        
    }
}