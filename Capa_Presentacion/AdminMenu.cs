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
    public partial class AdminMenu: Form {
        SqlInterfaz sq = new SqlInterfaz();

        public AdminMenu()
        {
            InitializeComponent();
            grdTodos.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPartidos ap = new AdminPartidos();
            this.Hide();
            ap.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEquipos ad = new AdminEquipos();
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLigas al = new AdminLigas();
            this.Hide();
            al.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUsers au = new AdminUsers();
            this.Hide();
            au.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            this.Hide();
            rep.ShowDialog();
            this.Show();
        }
    }
    
}
