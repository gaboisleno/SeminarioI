using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class Liga
    {
        private string nombre;
        private int id;
        private string ultimo_campeon;

        //Setters
        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public void setId(int id) {
            this.id = id;
        }

        public void setUltimoCampeon(string ultCamp) {
            this.ultimo_campeon = ultCamp;
        }

        //Getters
        public string getNombre() {
            return this.nombre;
        }

        public int getId() {
            return this.id;
        }

        public string getUltimoCampeon() {
            return this.ultimo_campeon;
        }
    }
}
