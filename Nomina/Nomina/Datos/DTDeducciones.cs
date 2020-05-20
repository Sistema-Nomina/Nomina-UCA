using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTDeducciones
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Deducciones> ListarDeducciones()
        {
            List<Nomina.Entidades.Deducciones> listaDeduccion = new List<Nomina.Entidades.Deducciones>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Deducciones;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Deducciones a = new Nomina.Entidades.Deducciones()
                    {
                        IdDeduccion = Convert.ToInt32(idr["IdDeducciones"]),
                        Nombre = idr["Nombre"].ToString(),
                        Descripcion = idr["Descripcion"].ToString()
                    };

                    listaDeduccion.Add(a);

                }
                idr.Close();

                return listaDeduccion;
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
            return listaDeduccion;
        }

        public Int32 guardarDeduccion(Entidades.Deducciones a)
        {
            int guardado = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Insert into nomina.Deducciones(Nombre, Descripcion) Values('" + a.Nombre + "','" + a.Descripcion + "');");
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

        public DTDeducciones()
        {
        }
    }
}
