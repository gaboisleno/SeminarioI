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
            Usuario usr = new Usuario();
            SqlInterfaz sq = new SqlInterfaz();

            usr.setUsername(txbxUsr.Text.ToLower());
            usr.setPasswrd(txbxPsw.Text);
            
            

            if (sq.Identificarse(usr))
            {
                Session["Autenticado"] = true;

                if (usr.getRol().Equals("ADMIN"))
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("Menu.aspx");
                } 
            }

      
        }

        protected void txbxUsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}