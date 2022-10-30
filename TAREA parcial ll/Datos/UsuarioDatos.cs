using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuarioDatos
    {


        public async Task<bool> LoginAsync( string clave, string correo)
        {
            bool valido = false;
            try
            {
                string sql = "SELECT 1 FROM usuario WHERE  Clave=@clave AND Correo=@correo";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 20).Value = clave;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 20).Value = correo;

                        valido = Convert.ToBoolean(await comando.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return valido;
        }

        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Usuario";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public async Task<bool> insertarAsync(Usuario usuario)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO usuario VALUE (@Codigo, @Clave, @Correo)";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 20).Value = usuario.Codigo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 20).Value = usuario.Clave;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 20).Value = usuario.Correo;

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return inserto;
        }

        public async Task<bool> actualizarAsync(Usuario usuario)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE usuario SET Clave=@Clave, Correo=@Correo WHERE Codigo=@Coigo;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 20).Value = usuario.Codigo;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 20).Value = usuario.Clave;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 20).Value = usuario.Correo;

                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return actualizo;
        }

        public async Task<bool> eliminarAsync(string codigo)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM usuario WHERE Codigo = @Codigo";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 20).Value = codigo;
                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return elimino;
        }

        
    }
}
