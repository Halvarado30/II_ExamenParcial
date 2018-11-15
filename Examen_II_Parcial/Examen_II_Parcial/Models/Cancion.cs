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
    
    class Cancion
    { 
        // Definimos las propiedades
        public int id { get; set; }
        public string nombre { get; set; }
        public int artista { get; set; }
        public int album { get; set; }
        public string genero { get; set; }
        public string aniocreacion { get; set; }

        //Métodos
        /// <summary>
        /// Obtiene una cancion desde la tabla Music.Cancion
        /// </summary>
        /// <param name="nombre">El nombre de la canción</param>
        /// <retuns>Un objeto de tipo Cancion</retuns>

        public static Cancion ObtenerCancion(string nombreC)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");
            string sql;
            Cancion result = new Cancion();

            // QUERY SQL
            sql = @"SELECT * 
                    FROM Music.Cancion
                    WHERE Nombre = @nombre";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 200).Value = nombreC;
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    result.id = Convert.ToInt16(rdr[0]);
                    result.nombre = rdr.GetString(1);
                    result.artista = Convert.ToInt16(rdr[2]);
                    result.album = Convert.ToInt16(rdr[3]);
                    result.genero = rdr.GetString(4);
                    result.aniocreacion = rdr.GetString(5);
                }

                return result;
            }
            catch (SqlException ex)
            {
                return result;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        /// <summary>
        /// Método para la inserción de datos
        /// </summary>
        public static bool InsertarCancion(Cancion canc)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "BulletProofRecords");
            SqlCommand cmd = conexion.EjecutarComando("sp_insertarCancion");

            // Definir el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros para el stored procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 200));
            cmd.Parameters["@nombre"].Value = canc.nombre;
            cmd.Parameters.Add(new SqlParameter("@artista", SqlDbType.Int));
            cmd.Parameters["@artista"].Value = canc.artista;
            cmd.Parameters.Add(new SqlParameter("@album", SqlDbType.Int));
            cmd.Parameters["@album"].Value = canc.album;
            cmd.Parameters.Add(new SqlParameter("@genero", SqlDbType.NVarChar, 100));
            cmd.Parameters["@genero"].Value = canc.genero;
            cmd.Parameters.Add(new SqlParameter("@aniocreacion", SqlDbType.NVarChar, 4));
            cmd.Parameters["@aniocreacion"].Value = canc.aniocreacion;

            // Ejecutamos el procedimiento
            try
            {
                conexion.EstablecerConexion();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
