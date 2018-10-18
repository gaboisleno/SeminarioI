using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Web
{
    public partial class Menu : System.Web.UI.Page
    {
        SqlInterfaz sq = new SqlInterfaz();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");
            GridView1.DataBind();

        }

        protected void closeSession(object sender, EventArgs e)
        {
            //Acciones
            Session["Autenticado"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridPartidosAyer(object sender, EventArgs e) {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos_ayer;");
            GridView1.DataBind();
        }

        protected void GridPartidosHoy(object sender, EventArgs e)
        {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos_hoy;");
            GridView1.DataBind();
        }

        protected void GridPartidosTodos(object sender, EventArgs e)
        {
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");
            GridView1.DataBind();
        }
    }
}