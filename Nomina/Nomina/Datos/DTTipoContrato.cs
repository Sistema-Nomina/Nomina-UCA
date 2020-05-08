using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTTipoContrato
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Tipo_Contrato> ListarTipoContrato()
        {
            List<Nomina.Entidades.Tipo_Contrato> listaTipoContrato = new List<Nomina.Entidades.Tipo_Contrato>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from TipoContrato;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Tipo_Contrato a = new Nomina.Entidades.Tipo_Contrato()
                    {
                        IdTipo_Contrato = Convert.ToInt32(idr["IdTipo_Contrato"]),
                        Descripcion = idr["Descripcion"].ToString()
                    };

                    listaTipoContrato.Add(a);

                }
                idr.Close();

                return listaTipoContrato;
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
            return listaTipoContrato;
        }

        public DTTipoContrato()
        {
        }
    }
}
