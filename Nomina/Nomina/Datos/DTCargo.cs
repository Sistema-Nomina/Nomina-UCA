using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTCargo
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Cargo> ListarCargo()
        {
            List<Nomina.Entidades.Cargo> listaCargo = new List<Nomina.Entidades.Cargo>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Cargo;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Cargo a = new Nomina.Entidades.Cargo()
                    {
                        IdCargo = Convert.ToInt32(idr["IdCargo"]),
                        Nombre = idr["Nombre"].ToString()
                    };

                    listaCargo.Add(a);

                }
                idr.Close();

                return listaCargo;
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
            return listaCargo;
        }

        public DTCargo()
        {
        }
    }
}
