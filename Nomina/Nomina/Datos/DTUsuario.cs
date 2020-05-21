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

        public Int32 guardarUsuario(Entidades.Usuario a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Usuario(IdEmpleado, Usuario, Pwd, Fecha_Creacion, Activo) Values(" + a.IdEmpleado + ",'" + a.Usuarios + "','" + a.Pwd + "', Now(), '"+ a.Activo + "');");
            /*sb.Append("(Nombre, Extension, NumeroRUC)");
            sb.Append("VALUES('"+ a.Nombre + "','" + a.Extension + "'," + a.NumeroRuc + ";");*/

            try
            {
                con.Open();
                guardado = con.Ejecutar(CommandType.Text, sb.ToString());
                return guardado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public Int32 idusuario()
        {
            Int32 idusuario = 0;
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("SELECT max(IdUsuario) as id from Usuario;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    idusuario = Convert.ToInt32(idr["id"]);
                }
                idr.Close();

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


            return idusuario;
        }

        public DTUsuario()
        {
        }
    }
}
