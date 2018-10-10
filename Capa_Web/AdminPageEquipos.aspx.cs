﻿using System;
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

            //Mostrar lista de las ligas
            ligas = sq.TraerLigas();
            foreach (Liga l in ligas){
                DropDownList1.Items.Add(l.getNombre());
            } 


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}