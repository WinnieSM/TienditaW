using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuarios> CD_ListarUsuarios()
        {
            List<Usuarios> ListaUsuarios = new List<Usuarios>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "SELECT iIdUsuario, cUsuario, cNombres, cApellidos, cCorreo, cPassword, lReestablecer, lActivo FROM dbo.Usuarios";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                       while(dr.Read())
                        {
                            ListaUsuarios.Add(
                                    new Usuarios()
                                    {
                                        iIdUsuario = Convert.ToInt32(dr["iIdUsuario"]),
                                        cUsuario = dr["cUsuario"].ToString(),
                                        cNombres = dr["cNombres"].ToString(),
                                        cApellidos = dr["cApellidos"].ToString(),
                                        cCorreo = dr["cCorreo"].ToString(),
                                        lReestablecer = Convert.ToBoolean(dr["lReestablecer"]),
                                        lActivo = Convert.ToBoolean(dr["lActivo"])
                                    }
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ListaUsuarios = new List<Usuarios>();
                throw ex;
            }

            return ListaUsuarios;
        }




    }
}
