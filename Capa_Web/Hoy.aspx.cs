using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class Hoy: System.Web.UI.Page {

        SqlInterfaz sq = new SqlInterfaz();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            grdHoy.DataSource = sq.TraerConsulta("SELECT * FROM partidos_hoy;");
            grdHoy.DataBind();
        }
        protected void closeSession(object sender, EventArgs e)
        {
            //Acciones
            Session["Autenticado"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void grdHoy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}