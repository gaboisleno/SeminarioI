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
    public partial class AdminPartidos: Form {

        SqlInterfaz sq = new SqlInterfaz();
        List<Equipo> equipos = new List<Equipo>();
        List<Liga> ligas = new List<Liga>();


        public AdminPartidos()
        {
            InitializeComponent();
            grdPartidos.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");

            //Cargar comboboxes
            equipos = sq.TraerEquipos();
            ligas = sq.TraerLigas();

            foreach (Equipo eq in equipos)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = eq.getNombre();
                item.Value = eq.getId();
                cmbxLocal.Items.Add(item);
                cmbxVisitante.Items.Add(item);
            }

            foreach (Liga eq in ligas)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = eq.getNombre();
                item.Value = eq.getId();
                cmbxLiga.Items.Add(item);
            }

        }

        private void AdminPartidos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Partido p = new Partido();
            p.setLiga(Convert.ToString((cmbxLiga.SelectedItem as ComboboxItem).Value));
            p.setLocal(Convert.ToString((cmbxLocal.SelectedItem as ComboboxItem).Value));
            p.setVisitante(Convert.ToString((cmbxVisitante.SelectedItem as ComboboxItem).Value));
            p.setFecha(txbxDate.Text);
            p.setHorario(txbxHour.Text);

            if (txbxGoalL.Text == "") p.setGolLocal(0);
            else p.setGolLocal(Convert.ToInt32(txbxGoalL.Text));

            if (txbxGoalV.Text == "") p.setGolVisitante(0);
            else p.setGolVisitante(Convert.ToInt32(txbxGoalV.Text));

            //
            if (rbtnIns.Checked) sq.NuevoPartido(p);
            else if (rbtnDel.Checked) sq.DeletePartido(p);
            else if (rbtnUpd.Checked) sq.UpdatePartido(p);

            grdPartidos.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");


        }

        private void rbtnIns_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIns.Checked) {
                rbtnUpd.Checked = false;
                rbtnDel.Checked = false;
            }

        }

        private void rbtnUpd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUpd.Checked)
            {
                rbtnIns.Checked = false;
                rbtnDel.Checked = false;
            }
        }

        private void rbtnDel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDel.Checked)
            {
                rbtnUpd.Checked = false;
                rbtnIns.Checked = false;
            }
        }

        private void grdPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
