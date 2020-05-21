using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTEmpleado
    {

        conexion con = new conexion();

        public List<Nomina.Entidades.Empleado> ListarEmpleado()
        {
            List<Nomina.Entidades.Empleado> listaEmpleado = new List<Nomina.Entidades.Empleado>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("select * from obtenerEmp_Suc_Empre;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Empleado a = new Nomina.Entidades.Empleado()
                    {
                        IdEmpleado = Convert.ToInt32(idr["IdEmpleado"]),
                        Nombre = idr["Nombre"].ToString(),
                        Apellidos = idr["Apellidos"].ToString(),
                        Cedula = idr["Cedula"].ToString(),
                        SalarioEmpleado = Convert.ToDouble(idr["SalarioEmpleado"]),
                        Fecha_contratacion = Convert.ToDateTime(idr["Fecha_Contratacion"]),
                        Direccion = idr["Direccion"].ToString(),
                        NombreEmpresa = idr["NombreEm"].ToString(),
                        NombreSucursal = idr["NombreS"].ToString(),

                    };

                    listaEmpleado.Add(a);

                }
                idr.Close();

                return listaEmpleado;
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
            return listaEmpleado;
        }

        public List<Nomina.Entidades.Empleado> ListarEmpleadoNoUsuario()
        {
            List<Nomina.Entidades.Empleado> listaEmpleado = new List<Nomina.Entidades.Empleado>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("select e.IdEmpleado, e.Nombre, e.Apellidos, e.Cedula, e.Fecha_Contratacion,e.SalarioEmpleado, e.Direccion from Empleado e left join Usuario u on e.IdEmpleado=u.IdEmpleado where u.IdEmpleado is null;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Empleado a = new Nomina.Entidades.Empleado()
                    {
                        IdEmpleado = Convert.ToInt32(idr["IdEmpleado"]),
                        Nombre = idr["Nombre"].ToString(),
                        Apellidos = idr["Apellidos"].ToString(),
                        Cedula = idr["Cedula"].ToString(),
                        SalarioEmpleado = Convert.ToDouble(idr["SalarioEmpleado"]),
                        Fecha_contratacion = Convert.ToDateTime(idr["Fecha_Contratacion"]),
                        Direccion = idr["Direccion"].ToString(),
                        //NombreEmpresa = idr["NombreEm"].ToString(),
                        //NombreSucursal = idr["NombreS"].ToString(),

                    };

                    listaEmpleado.Add(a);

                }
                idr.Close();

                return listaEmpleado;
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
            return listaEmpleado;
        }

        public Int32 guardarEmpleado(Entidades.Empleado a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Empleado(Nombre, Apellidos, Cedula, NivelEstudio, INSS_Empleado, Fecha_Contratacion, " +
            	"IdEstado, Direccion, SalarioEmpleado, IdPlanilla, IdArea, IdContrato, IdSucural, IdCargo) " +
            	"Values('" + a.Nombre + "','" + a.Apellidos + "','" + a.Cedula + "','" + a.NivelEstudio + "','"+ a.Inss_Empleado + "', Now()," +
                a.IdEstado+ ",'" + a.Direccion + "'," + a.SalarioEmpleado + "," + a.IdPlanilla + "," + a.IdArea + "," + a.IdContrato + ","+ a.IdSucursal + "," + a.IdCargo + ");");
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

        public DTEmpleado()
        {
        }
    }
}
