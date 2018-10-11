﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class AdminPageLigas: System.Web.UI.Page {
        SqlInterfaz sq = new SqlInterfaz();
        List<Equipo> equipos = new List<Equipo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            { 
                //Mostrar lista de equipos local y visitante 
                DDListEquipos.Items.Clear();
                equipos = sq.TraerEquipos();
                foreach (Equipo eq in equipos)
                {
                   DDListEquipos.Items.Add(new ListItem(eq.getNombre(), eq.getId().ToString()));

                }
            }
        }

        protected void DDListEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Liga l = new Liga();
            l.setNombre(txbxLiga.Text);

            if (CheckBox1.Checked) l.setUltimoCampeon(Convert.ToInt32(DDListEquipos.SelectedItem.Value));
            else l.setUltimoCampeon(0);

            sq.NuevaLiga(l);
        
            Response.Write(DDListEquipos.SelectedItem.Value);
        }



        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txbxLiga.ReadOnly = true;
        }
    }
}