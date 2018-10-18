using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class Ayer: System.Web.UI.Page {
        SqlInterfaz sq = new SqlInterfaz();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            grdAyer.DataSource = sq.TraerConsulta("SELECT * FROM partidos_ayer;");
            grdAyer.DataBind();
        }

        protected void closeSession(object sender, EventArgs e)
        {
            //Acciones
            Session["Autenticado"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void grdAyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}