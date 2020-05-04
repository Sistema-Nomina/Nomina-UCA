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
        public DTEmpresa()
        {
        }
    }
}
