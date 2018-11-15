using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace Examen_II_Parcial.Models
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        // Definir los constructores
        public Conexion() { }

        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }

        // Métodos
        /// <summary>
        /// Realiza una conexión al servidor de la base de datos.
        /// Requiere el nombre del servidor más la instancia.
        /// A su vez requiere de la base de datos
        /// </summary>
         public void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"server = " + servidor + ";" +
                                        "integrated security = true; database = " + baseDatos + ";");
                // Establecer conexión
                conn.Open();
            }
            catch (Exception)
            {
                throw; 
            }

        }

        /// <summary>
        /// Ejecuta un comando
        /// </summary>
        public SqlCommand EjecutarComando(string elcomando)
        {
            return cmd = new SqlCommand(elcomando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor sql
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
