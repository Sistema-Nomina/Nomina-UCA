using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nomina.Datos
{
    public class DTPlantilla
    {
        conexion con = new conexion();

        public List<Nomina.Entidades.Planilla> ListarPlanilla()
        {
            List<Nomina.Entidades.Planilla> listaPlanilla = new List<Nomina.Entidades.Planilla>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE nomina;");
            sb.Append("Select * from Planilla;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Nomina.Entidades.Planilla a = new Nomina.Entidades.Planilla()
                    {
                        IdPlanilla = Convert.ToInt32(idr["IdPlanilla"]),
                        Tipo_planilla = idr["Tipo_Planilla"].ToString()
                    };

                    listaPlanilla.Add(a);

                }
                idr.Close();

                return listaPlanilla;
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
            return listaPlanilla;
        }
        public DTPlantilla()
        {
        }
    }
}
