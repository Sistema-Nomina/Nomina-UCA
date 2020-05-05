using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTPago
    {

        conexion con = new conexion();

        public List<Nomina.Entidades.Pago> ListarPago()
        {
            List<Nomina.Entidades.Pago> listaPago = new List<Nomina.Entidades.Pago>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Pago;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Pago a = new Nomina.Entidades.Pago()
                    {
                        IdPago = Convert.ToInt32(idr["IdPago"]),
                        IdEmpleado = Convert.ToInt32(idr["IdEmpleado"]),
                        Fecha_pago = Convert.ToDateTime(idr["Fecha_Pago"]),
                        IdMoneda = Convert.ToInt32(idr["IdMoneda"])
                    };

                    listaPago.Add(a);

                }
                idr.Close();

                return listaPago;
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
            return listaPago;
        }

        public DTPago()
        {
        }


    }
}
