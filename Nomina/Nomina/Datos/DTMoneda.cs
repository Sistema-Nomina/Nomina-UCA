using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTMoneda
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Moneda> ListarMoneda()
        {
            List<Nomina.Entidades.Moneda> listaMoneda = new List<Nomina.Entidades.Moneda>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Moneda;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Moneda a = new Nomina.Entidades.Moneda()
                    {
                        IdMoneda = Convert.ToInt32(idr["IdMoneda"]),
                        Nombre = idr["Nombre"].ToString(),
                        Cambio = Convert.ToDouble(idr["Cambio"])
                    };

                    listaMoneda.Add(a);

                }
                idr.Close();

                return listaMoneda;
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
            return listaMoneda;
        }

        public DTMoneda()
        {
        }
    }
}
