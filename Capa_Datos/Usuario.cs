using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Usuario
    {
        private int     id;
        private string  username;
        private string  password;
        private string email;
        private string  rol;


        public Usuario() { }

        public Usuario(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public void setEmail(string email) {
            this.email = email;
        }

        public void setUsername(string name) {
            this.username = name;
        }

        public string getUsername() {
            return username;
        }

        public string getEmail() {
            return email;
        }

        public void setPasswrd(string pass) {
            this.password = pass;
        }

        public string getPasswrd() {
            return password;
        }

        public void setRol(string rol) {
            this.rol = rol;
        }

        public string getRol() {
            return rol;
        }

        public void setId(int id) {
            this.id = id;
        }

        public int getId() {
            return id;
        }

    }
}
