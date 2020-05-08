using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTArea
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Area> ListarArea()
        {
            List<Nomina.Entidades.Area> listaArea = new List<Nomina.Entidades.Area>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Area;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Area a = new Nomina.Entidades.Area()
                    {
                        IdArea = Convert.ToInt32(idr["IdArea"]),
                        Nombre = idr["Nombre"].ToString(),
                        IdDepartamento = Convert.ToInt32(idr["IdDepartamento"]),
                    };

                    listaArea.Add(a);

                }
                idr.Close();

                return listaArea;
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
            return listaArea;
        }

        public DTArea()
        {
        }
    }
}
