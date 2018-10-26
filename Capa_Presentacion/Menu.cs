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

namespace Semi.Presentacion {
    public partial class Menu: Form {
        SqlInterfaz sq = new SqlInterfaz();

        public Menu()
        {
            InitializeComponent();
            
            List<Partido> partidos = new List<Partido>();

            grdMenu.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");

            partidos = sq.TraerPartidos();
            //Mostrar partidos
          //  foreach (Partido p in partidos) {
           //     TextInfo.Text = TextInfo.Text + p.getLiga() + " " +p.getFecha()+"\n"+p.getLocal()+" [ "+p.getGolLocal()+" : "+p.getGolVisitante()+" ] "+p.getVisitante()+"\n\n";
            //}
            


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            grdMenu.DataSource = sq.TraerConsulta("SELECT * FROM partidos_todos;");
        }

        private void rbtnHoy_CheckedChanged(object sender, EventArgs e)
        {
            grdMenu.DataSource = sq.TraerConsulta("SELECT * FROM partidos_hoy;");
        }

        private void rbtnAyer_CheckedChanged(object sender, EventArgs e)
        {
            grdMenu.DataSource = sq.TraerConsulta("SELECT * FROM partidos_ayer;");
        }
    }



}
