using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTEstado
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Estado> ListarEsado()
        {
            List<Nomina.Entidades.Estado> listaEstado = new List<Nomina.Entidades.Estado>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Estado;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Estado a = new Nomina.Entidades.Estado()
                    {
                        IdEstado = Convert.ToInt32(idr["IdEstado"]),
                        Nombre = idr["Nombre"].ToString()
                    };

                    listaEstado.Add(a);

                }
                idr.Close();

                return listaEstado;
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
            return listaEstado;
        }

        public DTEstado()
        {
        }
    }
}
