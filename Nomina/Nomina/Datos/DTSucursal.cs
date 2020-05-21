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
            sb.Append("Select * from sucursal_empresa;");

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
                        NombreEmpresa = idr["nombreEm"].ToString(),
                        //NumeroRuc = Convert.ToInt32(idr["NumeroRUC"])
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

        public Int32 modificarSucursal(Entidades.Sucursal a)
        {
            int modificar = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("use nomina;");
            sb.Append("UPDATE Sucursal set Nombre = '" + a.Nombre + "' ," +
                "Extension = '" + a.Extension + "', NumeroRUC=" + a.NumeroRuc +
                " Where IdSucursal =" + a.IdSucursal);

            try
            {
                con.Open();
                modificar = con.Ejecutar(CommandType.Text, sb.ToString());
                return modificar;
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
