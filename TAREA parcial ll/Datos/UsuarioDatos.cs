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

       

        
    }
}
