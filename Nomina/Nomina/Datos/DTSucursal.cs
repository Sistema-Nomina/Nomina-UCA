using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTSucursal
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Sucursal> ListarSucursal()
        {
            List<Nomina.Entidades.Sucursal> listaSucursal = new List<Nomina.Entidades.Sucursal>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Sucursal;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Sucursal a = new Nomina.Entidades.Sucursal()
                    {
                        IdSucursal = Convert.ToInt32(idr["IdSucursal"]),
                        Nombre = idr["Nombre"].ToString(),
                        Extension = idr["Extension"].ToString(),
                        NumeroRuc = Convert.ToInt32(idr["NumeroRUC"])
                    };

                    listaSucursal.Add(a);

                }
                idr.Close();

                return listaSucursal;
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
            return listaSucursal;
        }

        public Int32 guardarSucursal(Entidades.Sucursal a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Sucursal(Nombre, Extension, NumeroRUC) Values('"+a.Nombre+"','"+a.Extension+"',"+a.NumeroRuc+");");
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

        public DTSucursal()
        {
        }
    }
}
