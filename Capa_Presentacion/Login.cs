using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Capa_Datos;

namespace Semi.Presentacion
{
    public partial class Login : Form
    {
        SqlInterfaz sq = new SqlInterfaz();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txbxUser.Text.ToLower(), txbxPasswrd.Text.ToLower());

      

            if (sq.Identificarse(user) == true)
            {
                this.Hide();
                Menu mainMenu = new Menu();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
        
        }

        private void txbxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
