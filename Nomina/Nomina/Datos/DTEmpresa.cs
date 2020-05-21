using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTEmpresa
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Empresa> ListarEmpresa()
        {
            List<Nomina.Entidades.Empresa> listaEmpresa = new List<Nomina.Entidades.Empresa>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Empresa;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Empresa a = new Nomina.Entidades.Empresa()
                    {
                        NumeroRuc = Convert.ToInt32(idr["NumeroRUC"]),
                        Nombre = idr["Nombre"].ToString(),
                        Telefono = idr["Telefono"].ToString(),
                        Direccion = idr["Direccion"].ToString(),
                    };

                    listaEmpresa.Add(a);

                }
                idr.Close();

                return listaEmpresa;
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
            return listaEmpresa;
        }

        public Int32 guardarEmpresa(Entidades.Empresa a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Empresa(NumeroRUC, Nombre, Telefono, Direccion) Values("+a.NumeroRuc+ ",'" + a.Nombre + "','" + a.Telefono + "','"+a.Direccion+ "');");
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

        public Int32 modificarEmpresa(Entidades.Empresa a)
        {
            int modificar = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("use nomina;");
            sb.Append("UPDATE Empresa set Nombre = '" + a.Nombre + "' ," +
                "Telefono = '" + a.Telefono + "', Direccion='"+a.Direccion +"'"+
                "Where NumeroRUC =" + a.NumeroRuc);

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

        public DTEmpresa()
        {
        }
    }
}
