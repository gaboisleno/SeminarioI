using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace Capa_Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Usuario newUser = new Usuario();
            SqlInterfaz sq = new SqlInterfaz();

            //Comprobar constraseñas
            if (txbxPsw.Text.Equals(txbxConPsw.Text))
            {
                newUser.setPasswrd(txbxPsw.Text);
                newUser.setUsername(txbxUsr.Text.ToLower());
                newUser.setEmail(txbxMail.Text.ToLower());
                newUser.setRol("USR");

                if (sq.NuevoUsuario(newUser))
                {
                    //Mostrar Mensaje/Pagina usuario creado correctamente
                    Response.Write("Usuario creado. Intente iniciar sesion.");
                }
                else
                {
                    //Mostrar mensaje error al crear usuario
                    Response.Write("Error al crear usuario, intente mas tarde.");
                }
            }
            else
            {
                //Mostrar error contrasña no coincide
                Response.Write("Las contraseñas no coinciden.");
            }
        }
    }
}