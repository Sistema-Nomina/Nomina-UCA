using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTRol
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Rol> ListarRol()
        {
            List<Nomina.Entidades.Rol> listaRol = new List<Nomina.Entidades.Rol>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Rol;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Rol a = new Nomina.Entidades.Rol()
                    {
                        IdRol = Convert.ToInt32(idr["IdRol"]),
                        Nombre = idr["Nombre"].ToString()
                    };

                    listaRol.Add(a);

                }
                idr.Close();

                return listaRol;
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
            return listaRol;
        }

        public DTRol()
        {
        }
    }
}
