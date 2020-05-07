using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTPago_Deduccion
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Pago_Deduccion> ListarPago_Deduccion()
        {
            List<Nomina.Entidades.Pago_Deduccion> listaPago_Deduccion = new List<Nomina.Entidades.Pago_Deduccion>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Pago_Deduccion;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Pago_Deduccion a = new Nomina.Entidades.Pago_Deduccion()
                    {
                        IdEmpleado_Deduccion = Convert.ToInt32(idr["IdEmpleado_Deduccion"]),
                        IdPago = Convert.ToInt32(idr["IdPago"]),
                        IdDeduccion = Convert.ToInt32(idr["IdDeducciones"]),
                        Monto = Convert.ToDouble(idr["Monto"])
                    };

                    listaPago_Deduccion.Add(a);

                }
                idr.Close();

                return listaPago_Deduccion;
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
            return listaPago_Deduccion;
        }

        public DTPago_Deduccion()
        {
        }
    }
}
