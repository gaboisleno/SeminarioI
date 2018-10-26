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

 
        public Menu()
        {
            InitializeComponent();
            SqlInterfaz sq = new SqlInterfaz();
            List<Partido> partidos = new List<Partido>();


            partidos = sq.TraerPartidos();
            //Mostrar partidos
            foreach (Partido p in partidos) {
                TextInfo.Text = TextInfo.Text + p.getLiga() + " " +p.getFecha()+"\n"+p.getLocal()+" [ "+p.getGolLocal()+" : "+p.getGolVisitante()+" ] "+p.getVisitante()+"\n\n";
            }
            


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
    }



}
