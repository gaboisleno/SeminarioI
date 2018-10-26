using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Semi.Presentacion {
    public partial class Register: Form {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nuevo usuario;

            Usuario newUser = new Usuario();
            SqlInterfaz sq = new SqlInterfaz();

            //Comprobar constraseñas
            if (txbxPsw.Text.Equals(txbxConfirm.Text))
            {
                newUser.setPasswrd(txbxPsw.Text);
                newUser.setUsername(txbxUsr.Text.ToLower());
                newUser.setEmail(txbxMail.Text.ToLower());
                newUser.setRol("USR");

                if (sq.NuevoUsuario(newUser))
                {
                    //Mostrar Mensaje/Pagina usuario creado correctamente
                    this.Close();
                }
                else
                {
                    //Mostrar mensaje error al crear usuario
                }
            }
            else
            {
                //Mostrar error contrasña no coincide
                
            }

        }
    }
}
