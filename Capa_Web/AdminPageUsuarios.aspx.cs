using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web {
    public partial class AdminPageUsuarios: System.Web.UI.Page {
        SqlInterfaz sq = new SqlInterfaz();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Autenticado"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            GridView1.DataSource = sq.TraerConsulta("SELECT * FROM Usuarios;");
            GridView1.DataBind();
        }

        protected void rbtnAddAdmin_CheckedChanged(object sender, EventArgs e)
        {
            rbtnRmvAdmin.Checked = false;
            rbtnRmvUser.Checked = false;
        }

        protected void rbtnRmvAdmin_CheckedChanged(object sender, EventArgs e)
        {
            rbtnAddAdmin.Checked = false;
            rbtnRmvUser.Checked = false;
        }

        protected void rbtnRmvUser_CheckedChanged(object sender, EventArgs e)
        {
            rbtnAddAdmin.Checked = false;
            rbtnRmvAdmin.Checked = false;
        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbxId.Text);
            if (rbtnAddAdmin.Checked) sq.AdminUser(id, 1); //hacer admin
            else if (rbtnRmvAdmin.Checked) sq.AdminUser(id, 2); //quitar admin
            else if (rbtnRmvUser.Checked) sq.AdminUser(id, 3); //borrar usuario
        }
    }
}