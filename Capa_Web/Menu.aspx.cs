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
        

        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            


            List<Partido> partiData = new List<Partido>();
            SqlInterfaz sq = new SqlInterfaz();
            partiData = sq.TraerPartidos();

            try {
                grdPartidos.DataSource = partiData; //Metodo que devuelva una lista de partidos
                grdPartidos.DataBind();
            }
            catch { }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void closeSession(object sender, EventArgs e)
        {
            //Acciones
            Session["Autenticado"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}