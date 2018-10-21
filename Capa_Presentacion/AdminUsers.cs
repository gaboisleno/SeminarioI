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
    public partial class AdminUsers: Form {

        SqlInterfaz sq = new SqlInterfaz();

        public AdminUsers()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbxID.Text);
            if (rbtnSetAdmin.Checked) sq.AdminUser(id, 1); //hacer admin
            else if (rbtnRmvAdmin.Checked) sq.AdminUser(id, 2); //quitar admin
            else if (rbtnDelUser.Checked) sq.AdminUser(id, 3); //borrar usuario
        }

        private void rbtnSetAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSetAdmin.Checked) {
                rbtnRmvAdmin.Checked = false;
                rbtnDelUser.Checked = false;
            }
        }

        private void rbtnRmvAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRmvAdmin.Checked)
            {
                rbtnSetAdmin.Checked = false;
                rbtnDelUser.Checked = false;
            }
        }

        private void rbtnDelUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDelUser.Checked) {
                rbtnSetAdmin.Checked = false;
                rbtnRmvAdmin.Checked = false;
            }
        }
    }
}
