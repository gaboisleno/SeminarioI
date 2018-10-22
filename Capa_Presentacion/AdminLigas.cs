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

    public partial class AdminLigas: Form {

        SqlInterfaz sq = new SqlInterfaz();
        List<Equipo> equipos = new List<Equipo>();

        public AdminLigas()
        {
            //Cargar grilla
            InitializeComponent();
            grdLigas.DataSource = sq.TraerConsulta("SELECT * FROM Ligas ORDER BY Nombre ASC;");

            //Cargar comboboxes
            equipos = sq.TraerEquipos();
            foreach (Equipo eq in equipos)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = eq.getNombre();
                item.Value = eq.getId();
                cmbxEquipos.Items.Add(item);
                cmbxCampeon.Items.Add(item);
            }

        }
        //Nueva Liga
        private void btnInsLiga_Click(object sender, EventArgs e)
        {
            Liga l = new Liga();
            l.setNombre(txbxNewName.Text);

            if (checkBox1.Checked) l.setUltimoCampeon(Convert.ToInt32((cmbxEquipos.SelectedItem as ComboboxItem).Value));
            else l.setUltimoCampeon(0);

            sq.NuevaLiga(l);
            cleanTexts();
        }

        //Actualizar liga
        private void button2_Click(object sender, EventArgs e)
        {
            Liga lig = new Liga();
            lig.setUltimoCampeon(Convert.ToInt32((cmbxCampeon.SelectedItem as ComboboxItem).Value));
            lig.setId(Convert.ToInt32(txbxUpId.Text));
            sq.UpdateLiga(lig);
            cleanTexts();
        }

        //Borrar liga
        private void button3_Click(object sender, EventArgs e)
        {
            sq.DeleteLiga(Convert.ToInt32(txbxDelID.Text));
            cleanTexts();
           
            grdLigas.Refresh();

        }

        private void cleanTexts() {
            txbxNewName.Text = "";
            txbxDelID.Text = "";
            txbxUpId.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminLigas_Load(object sender, EventArgs e)
        {

        }

        private void cmbxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxCampeon.Refresh();
            
        }


    }

    //Clase para llenar el combobox
    public class ComboboxItem {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
