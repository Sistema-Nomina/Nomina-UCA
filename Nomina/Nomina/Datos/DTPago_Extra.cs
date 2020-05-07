using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTPago_Extra
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Pago_Extra> ListarPago_Extra()
        {
            List<Nomina.Entidades.Pago_Extra> listaPago_Extra = new List<Nomina.Entidades.Pago_Extra>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Pago_Extra;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Pago_Extra a = new Nomina.Entidades.Pago_Extra()
                    {
                        IdEmpleado_Extra = Convert.ToInt32(idr["IdEmpleado_Extra"]),
                        IdPago = Convert.ToInt32(idr["IdPago"]),
                        IdExtra = Convert.ToInt32(idr["IdExtra"]),
                        Monto = Convert.ToDouble(idr["Monto"])
                    };

                    listaPago_Extra.Add(a);

                }
                idr.Close();

                return listaPago_Extra;
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
            return listaPago_Extra;
        }

        public DTPago_Extra()
        {
        }
    }
}
