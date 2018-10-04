using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            Session["Autenticado"] = null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}