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
            String MyConString = "SERVER=localhost;" + "DATABASE=semifutbol;" + "UID=root;" + "PASSWORD=rosario12;";

            MySqlConnection conn = new MySqlConnection(MyConString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM partidos_todos;", conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);

            GridView1.DataSource = dataTable;
            GridView1.DataBind();


            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
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
    }
}