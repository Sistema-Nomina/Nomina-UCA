using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTUsuario
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Usuario> ListarUsuario()
        {
            List<Nomina.Entidades.Usuario> listaUsuario = new List<Nomina.Entidades.Usuario>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Usuario;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Usuario a = new Nomina.Entidades.Usuario()
                    {
                        IdUsuario = Convert.ToInt32(idr["IdUsuario"]),
                        IdEmpleado = Convert.ToInt32(idr["IdEmpleado"]),
                        Usuarios = idr["Usuario"].ToString(),
                        Pwd = idr["Pwd"].ToString(),
                        Fecha_creacion = Convert.ToDateTime(idr["Fecha_Creacion"]),
                        Activo = idr["Activo"].ToString()
                    };

                    listaUsuario.Add(a);

                }
                idr.Close();

                return listaUsuario;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return listaUsuario;
        }
        public DTUsuario()
        {
        }
    }
}
