using System;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTUsuario_Rol
    {
        conexion con = new conexion();

        public Int32 guardarUsuario_Rol(Entidades.Usuario_Rol a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Usuario_Rol(IdUsuario, IdRol, Fecha_Creacion) Values(" + a.IdUsuario + "," + a.IdRol + ", Now());");
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

        public DTUsuario_Rol()
        {
        }
    }
}
