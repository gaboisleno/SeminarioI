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
            if (Session["Autenticado"] == null) Response.Redirect("Login.aspx");

            if (!this.IsPostBack)
            {
                //Mostrar lista de las ligas
                DDListLigas.Items.Clear();
                ligas = sq.TraerLigas();
                foreach (Liga l in ligas)
                {
                    DDListLigas.Items.Add(new ListItem(l.getNombre(), l.getId().ToString()));
                }

                //Mostrar lista de equipos local y visitante 
                DDListLocal.Items.Clear();
                equipos = sq.TraerEquipos();
                foreach (Equipo eq in equipos)
                {
                    DDListLocal.Items.Add(new ListItem(eq.getNombre(), eq.getId().ToString()));
                    DDListVisitante.Items.Add(new ListItem(eq.getNombre(), eq.getId().ToString()));
                }
            }
        }

        protected void DDListLiga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DDListLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DDListVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}