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
                        Monto = Convert.ToDouble(idr["Monto"]),
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

        public Int32 idpago()
        {
            Int32 idPago = 0;
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("SELECT max(IdPago) as id from Pago;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                if (idr.Read())
                {
                    idPago = Convert.ToInt32(idr["id"]);
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


            return idPago;
        }

        public Int32 guardarPago(Entidades.Pago a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Pago(IdEmpleado, IdMoneda, Monto, Fecha_Pago) Values(" + a.IdEmpleado + "," + a.IdMoneda + "," + a.Monto +", Now());");
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

        public DTPago()
        {
        }


    }
}
