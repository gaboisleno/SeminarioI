using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Web {
    public partial class Noticias: System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}