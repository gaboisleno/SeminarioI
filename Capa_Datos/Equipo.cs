using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Equipo
    {
        private int id;
        private string liga;
        private string nombre;
        private string pais;

        //Setters
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public void setLiga(string liga) {
            this.liga = liga;
        }

        public void setId(int id) {
            this.id = id;
        }

        public void setPais(string pais) {
            this.pais = pais;
        }

        //Getters
        public string getNombre() {
            return this.nombre;
        }

        public string getLiga() {
            return this.liga;
        }

        public int getId() {
            return this.id;
        }

        public string getPais() {
            return this.pais;
        }

    }
}
