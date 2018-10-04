using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Partido
    {

        private string fecha;
        private string local;
        private string visitante;

        private string horario;
        private int golesLocal;
        private int golesVisitante;

        private string liga;

        //Sets
        public void setFecha(string fecha) {
            this.fecha = Convert.ToDateTime(fecha).ToString("dd-MM-yyyy");
        }

        public void setLocal(string local) {
            this.local = local;
        }

        public void setVisitante(string visitante) {
            this.visitante = visitante;
        }

        public void setGolLocal(int x)
        {
            this.golesLocal = x;
        }

        public void setGolVisitante(int x)
        {
            this.golesVisitante = x;
        }

        public void setLiga(string liga) {
            this.liga = liga;
        }

        //Gets
        public string getFecha() {
            return this.fecha;
        }

        public string getLocal() {
            return this.local;
        }

        public string getVisitante() {
            return this.visitante;
        }

        public int getGolLocal() {
            return this.golesLocal;
        }

        public int getGolVisitante() {
            return this.golesVisitante;
        }

        public string getLiga() {
            return this.liga;
        }
        






    }
}
