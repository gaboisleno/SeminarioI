﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web
{
    public partial class AdminPage : System.Web.UI.Page
    {
        SqlInterfaz sq = new SqlInterfaz();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos ORDER BY Fecha DESC;");
            GridView1.DataBind();
        }


        protected void GridPartidosAdmin(object sender, EventArgs e) {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos ORDER BY Fecha DESC;");
            GridView1.DataBind();

        }

        protected void GridEquiposAdmin(object sender, EventArgs e)
        {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM equipos ORDER BY ID ASC;");
            GridView1.DataBind();

        }

        protected void GridLigasAdmin(object sender, EventArgs e)
        {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM ligas;");
            GridView1.DataBind();

        }

        protected void closeSession(object sender, EventArgs e)
        {
            //Acciones
            Session["Autenticado"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}