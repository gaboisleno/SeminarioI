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

            if (sq.Identificarse(user))
            {

                if (user.getRol().Equals("ADMIN"))
                {
                    AdminMenu admMenu = new AdminMenu();
                    this.Hide();
                    admMenu.ShowDialog();
                    
                }
                else
                {
                    Menu mainMenu = new Menu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
                this.Show();
                this.txbxUser.Text = "";
                this.txbxPasswrd.Text = "";
            }
        }

        private void txbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
