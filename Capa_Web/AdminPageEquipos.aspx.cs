using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class AdminPageEquipos: System.Web.UI.Page {

        SqlInterfaz sq = new SqlInterfaz();
        List<Liga> ligas = new List<Liga>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            //Mostrar la tabla de equipos
            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM equipos ORDER BY Nombre ASC;");
            GridView1.DataBind();


            DDListLigas.Items.Clear();
            //Mostrar lista de las ligas
            ligas = sq.TraerLigas();
            foreach (Liga l in ligas){
                DDListLigas.Items.Add(new ListItem(l.getNombre(), l.getId().ToString()));
               
            } 


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Equipo equipoTemp = new Equipo();
            equipoTemp.setNombre(txbxEquipo.Text);
            equipoTemp.setLiga(Int32.Parse(DDListLigas.SelectedValue));

            if (sq.NuevoEquipo(equipoTemp)){
                txbxEquipo.Text = "";
            }
        }

        protected void DDListLigas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}