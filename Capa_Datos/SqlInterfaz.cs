﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Capa_Datos {
    public class SqlInterfaz {

        
        public bool AbrirConexionSql(MySqlConnection Conexion)
        {
            string sql = ";server=localhost;user id=root;database=semifutbol;password=rosario12";
            Conexion.ConnectionString = sql;

            try
            {
                Conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Identificarse(Usuario unknow)
        {
            Usuario user = new Usuario();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);
                
                Query.CommandText = "SELECT usuario, passwrd, rol, id_usr, e_mail FROM usuarios WHERE usuario='" + unknow.getUsername().ToLower() + "'";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                //Si la consulta no esta vacia
                if (consulta.Read())
                {
                    user.setUsername(consulta.GetString("USUARIO").ToLower());
                    user.setPasswrd(consulta.GetString("PASSWRD"));
                    user.setRol(consulta.GetString("ROL"));
                    user.setId(consulta.GetInt32("ID_USR"));
                    user.setEmail(consulta.GetString("E_MAIL"));

                    //Compara usuario y password ingresados
                    if (unknow.getUsername().Equals(user.getUsername()) && unknow.getPasswrd().Equals(user.getPasswrd()))
                    {
                        unknow.setEmail(user.getEmail());
                        unknow.setId(user.getId());
                        unknow.setRol(user.getRol());
                        unknow.setUsername(user.getUsername());
                        unknow.setPasswrd(user.getPasswrd());

                        Conexion.Close();
                        return true;
                    }
                }
                Conexion.Close();
                return false;
       
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
      
        public bool NuevoUsuario(Usuario user)
        {

            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            AbrirConexionSql(Conexion);

            if ((BuscarUsuario(user.getUsername())==false) && (BuscarUsuarioEmail(user.getEmail())==false)) {
                //Insertar el usuario aqui...
                Query.CommandText = "INSERT INTO USUARIOS(USUARIO, PASSWRD, ROL, E_MAIL) VALUES ('" + user.getUsername() + "','" + user.getPasswrd() + "','USR','" + user.getEmail() + "');";
                Query.Connection = Conexion;
                consulta = Query.ExecuteReader();

                Conexion.Close();
                return true;
            }

            Conexion.Close();
            return false;
        }

        public bool NuevoEquipo(Equipo equipo) {
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            AbrirConexionSql(Conexion);
                //Insertar el usuario aqui...
                Query.CommandText = "INSERT INTO EQUIPOS(NOMBRE,LIGA) VALUES ('" +equipo.getNombre()+ "','" + equipo.getLiga() +"');";
                Query.Connection = Conexion;
                consulta = Query.ExecuteReader();

                Conexion.Close();
                return true;
        }

        public bool NuevaLiga(Liga liga)
        {
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            AbrirConexionSql(Conexion);
            //Insertar aqui...
            if (liga.getUltimoCampeon()==0)
            {
                Query.CommandText = "INSERT INTO LIGAS(NOMBRE) VALUES ('" + liga.getNombre() + "');";
            }
            else
            {
                Query.CommandText = "INSERT INTO LIGAS(NOMBRE,CAMPEON_ACTUAL) VALUES ('" + liga.getNombre() + "','" +liga.getUltimoCampeon()+"');";
            }
            
            Query.Connection = Conexion;
            consulta = Query.ExecuteReader();

            Conexion.Close();
            return true;
        }

        public bool NuevoPartido(Partido partido) {
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            AbrirConexionSql(Conexion);
            //Insertar aqui...
            
            Query.CommandText = "INSERT INTO PARTIDOS () VALUES ();";
            

            Query.Connection = Conexion;
            consulta = Query.ExecuteReader();

            Conexion.Close();
            return true;
        }

        public bool BuscarUsuario(string username)
        {

            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);

                //Comprobar username
                Query.CommandText = "SELECT usuario FROM usuarios WHERE usuario='" + username + "'";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                //Si la consulta no esta vacia
                if (consulta.Read())
                {
                    Console.WriteLine("Usuario encontrado");
                    Conexion.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado");
                    Conexion.Close();
                    return false;
                }

            }
            catch
            {
                Console.WriteLine("Error en buscarusuario");
            }

            Conexion.Close();
            return true;
        }

        public bool BuscarUsuarioEmail(string mail) {
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);

                //Comprobar username
                Query.CommandText = "SELECT E_MAIL FROM usuarios WHERE E_MAIL='" + mail+"'";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                //Si la consulta no esta vacia
                if (consulta.Read())
                {
                    Console.WriteLine("email encontrado");
                    Conexion.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("email no encontrado");
                    Conexion.Close();
                    return false;
                }

            }
            catch
            {
                Console.WriteLine("Error en buscarusuariomail");
            }

            return true;
        }

        public DataTable TraerConsulta(string consulta)
        {
            String MyConString = "SERVER=localhost;" + "DATABASE=semifutbol;" + "UID=root;" + "PASSWORD=rosario12;";
            MySqlConnection conn = new MySqlConnection(MyConString);
            MySqlCommand cmd = new MySqlCommand(consulta, conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);
            return dataTable;
        }

        public List<Equipo> TraerEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);

                Query.CommandText = "SELECT * FROM equipos";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                while (consulta.Read())
                {
                    Equipo e = new Equipo();

                    e.setId(consulta.GetInt32("ID"));
                    e.setNombre(consulta.GetString("NOMBRE"));
                    e.setLiga(consulta.GetInt32("LIGA"));

                    equipos.Add(e);
                }
                Conexion.Close();
                return equipos;
            }
            catch
            {
                Console.WriteLine("Se produjo un error al buscar los equipos");
                Conexion.Close();
                return equipos;
            }
        }

        public List<Liga> TraerLigas(){
            List<Liga> ligas = new List<Liga>();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);

                Query.CommandText = "SELECT * FROM ligas";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                while (consulta.Read())
                {
                    Liga l = new Liga();

                    l.setId(consulta.GetInt32("ID"));
                    l.setNombre(consulta.GetString("NOMBRE"));
                    //l.setUltimoCampeon(consulta.GetInt32("CAMPEON_ACTUAL"));
                    ligas.Add(l);
                }
                Conexion.Close();
                return ligas;
            }
            catch
            {
                Console.WriteLine("Se produjo un error al buscar los partidos");
                Conexion.Close();
                return ligas;
            }
        }

        public List<Partido> TraerPartidos()
        {
            List<Partido> partidos = new List<Partido>();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlCommand Query = new MySqlCommand();
            MySqlDataReader consulta;

            try
            {
                AbrirConexionSql(Conexion);

                Query.CommandText = "SELECT p.fecha AS FECHA, e.nombre AS LOCAL, p.gol_local AS L, e2.nombre AS VISITANTE, p.gol_visitante AS V, l.nombre AS LIGA FROM PARTIDOS p INNER JOIN EQUIPOS e on p.local=e.id INNER JOIN EQUIPOS e2 on p.visitante = e2.id INNER JOIN LIGAS l on p.liga = l.id ORDER BY FECHA DESC;";
                Query.Connection = Conexion;

                //Consultar
                consulta = Query.ExecuteReader();

                while (consulta.Read())
                {
                    Partido p = new Partido();

                    p.setFecha(consulta.GetString("FECHA"));
                    p.setLocal(consulta.GetString("LOCAL"));
                    p.setVisitante(consulta.GetString("VISITANTE"));
                    p.setGolLocal(consulta.GetInt32("L"));
                    p.setGolVisitante(consulta.GetInt32("V"));
                    p.setLiga(consulta.GetString("LIGA"));

                    partidos.Add(p);
                }
                Conexion.Close();
                return partidos;
            }
            catch
            {
                Console.WriteLine("Se produjo un error al buscar los partidos");
                Conexion.Close();
                return partidos;
            }

        }

    }
    

}




