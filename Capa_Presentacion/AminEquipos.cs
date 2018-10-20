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
    public partial class AminEquipos: Form {
        SqlInterfaz sq = new SqlInterfaz();

        public AminEquipos()
        {
            InitializeComponent();
            //Mostrar la tabla de equipos
            grdEquipos.DataSource = sq.TraerConsulta("SELECT * FROM equipos ORDER BY Nombre ASC;");
        }

        private void grdEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
