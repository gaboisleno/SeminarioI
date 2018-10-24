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

namespace Semi.Presentacion 
{
    public partial class AdminEquipos: Form {
        SqlInterfaz sq = new SqlInterfaz();
        List<Liga> ligas = new List<Liga>();

        public AdminEquipos()
        {
            InitializeComponent();
            //Mostrar la tabla de equipos
            grdEquipos.DataSource = sq.TraerConsulta("SELECT * FROM equipos ORDER BY Nombre ASC;");

            //Cargar comboboxes
            ligas = sq.TraerLigas();
            foreach (Liga eq in ligas)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = eq.getNombre();
                item.Value = eq.getId();
                cmbxInsLiga.Items.Add(item);
                cmbxUpdLiga.Items.Add(item);
            }
        }

        private void grdEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipo equipoTemp = new Equipo();
            equipoTemp.setNombre(txbxInsNombre.Text);
            equipoTemp.setLiga(Convert.ToInt32((cmbxInsLiga.SelectedItem as ComboboxItem).Value));


            if (sq.NuevoEquipo(equipoTemp))
            {
                txbxInsNombre.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (sq.DeleteEquipo(Int32.Parse(txbxDelId.Text)))
            {
                txbxDelId.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equipo n = new Equipo();
            n.setNombre(txbxUpdNombre.Text);
            n.setId(Int32.Parse(txbxUpdId.Text));
            n.setLiga(Convert.ToInt32((cmbxUpdLiga.SelectedItem as ComboboxItem).Value));
            sq.UpdateEquipo(n);
        }

        private void cmbxInsLiga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


